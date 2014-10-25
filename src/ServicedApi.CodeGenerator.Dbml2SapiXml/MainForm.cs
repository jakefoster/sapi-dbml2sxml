using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualStudio.TextTemplating;
using SimpleT4Engine.Api;
using org.ncore.Common;
using org.ncore.Diagnostics;

namespace org.ncore.ServicedApi.CodeGenerator.Dbml2SapiXml
{
    public partial class MainForm : Form
    {
        RichTextBoxTraceListener _richTextBoxListener;
        private static readonly string _binPath = Path.GetDirectoryName( Assembly.GetExecutingAssembly().GetName().CodeBase ).Remove( 0, 6 );

        public MainForm()
        {
            InitializeComponent();
        }

        private void _generateButton_Click( object sender, EventArgs e )
        {
            Spy.Trace( EventClass.Audit, "Begining generation." ); 
            try
            {
                string dbmlFileName = _dbmlFileNameTextBox.Text;
                string apiNamespace = _apiNamespaceTextBox.Text;
                var host = new TemplatingHost( ".xml", Encoding.UTF8 );
                host.DefaultParameters.Add( "ApiNamespace", apiNamespace );
                host.DefaultParameters.Add( "DbmlFileName", dbmlFileName );

                string templateFilePath = Path.Combine( _binPath, @"Templates\" );
                host.TemplateFile = Path.Combine( templateFilePath, "Dbml2Sapi.xml.t4" );

                // TODO: Maybe someday we want these as embedded resources but right now they're changing too much
                //  so instead we'll just copy the templates to the bin directory.  JF
                //string input = EmbeddedResource.LoadAsString( "Resources.Templates." + templateFileName );
                string input = File.ReadAllText( host.TemplateFile );

                var engine = new Engine();
                string output = engine.ProcessTemplate( input, host );

                string outputFileName = _outputFileNameTextBox.Text;
                File.WriteAllText( outputFileName, output, host.FileEncoding );

                if( host.Errors.HasErrors )
                {
                    Spy.Trace( EventClass.Audit, "Generation errors and/or warnings reported." );

                    foreach( CompilerError error in host.Errors )
                    {

                        Spy.Trace( error.IsWarning ? EventClass.Warning : EventClass.Error,
                                    "{0} {1} in {2} (line:{3}, column:{4})\r\n\t{5}",
                                    error.IsWarning ? "Warning" : "Error",
                                    error.ErrorNumber,
                                    error.FileName,
                                    error.Line,
                                    error.Column,
                                    error.ErrorText );
                    }
                }
                else
                {
                    Spy.Trace( EventClass.Audit, "No generation errors reported." );
                }
            }
            catch( Exception ex )
            {
                Spy.Trace( ex );
            }
            Spy.Trace( EventClass.Audit, "Generation complete." );
        }

        private void _openFileDialogButton_Click( object sender, EventArgs e )
        {
            _openFileDialog.ShowDialog( this );
        }

        private void _openFileDialog_FileOk( object sender, CancelEventArgs e )
        {
            string dbmlFileName = ( (OpenFileDialog)sender ).FileName;
            _dbmlFileNameTextBox.Text = dbmlFileName;

            string filePath = Path.GetDirectoryName( dbmlFileName );
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension( dbmlFileName );
            _outputFileNameTextBox.Text = Path.Combine( filePath, fileNameWithoutExtension + ".ServicedApi.xml" );
            _apiNamespaceTextBox.Text = fileNameWithoutExtension; // NOTE: Just a guess.  JF
        }

        private void _saveFileDialogButton_Click( object sender, EventArgs e )
        {
            _saveFileDialog.FileName = _outputFileNameTextBox.Text;
            _saveFileDialog.ShowDialog( this );
        }

        private void _saveFileDialog_FileOk( object sender, CancelEventArgs e )
        {
            if( !e.Cancel )
            {
                var dialog = (SaveFileDialog)sender;
                _outputFileNameTextBox.Text = dialog.FileName;
            }
        }

        private void MainForm_Load( object sender, EventArgs e )
        {
            _richTextBoxListener = new RichTextBoxTraceListener( _traceDisplayRichTextBox );
            Trace.Listeners.Add( _richTextBoxListener );

            Trace.Listeners.Add( new TextWriterTraceListener( File.Create( "trace.log" ) ) );
            Trace.AutoFlush = true;

            Spy.Trace( "Starting up!" );
        }
    }
}
