using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using org.ncore.Common;
using org.ncore.Extensions;

namespace org.ncore.ServicedApi.CodeGenerator.Dbml2SapiXml
{
    public class RichTextBoxTraceListener : TraceListener
    {
        private RichTextBox _target;
        private StringSendDelegate _invokeWrite;

        public RichTextBoxTraceListener( RichTextBox target )
        {
            _target = target;
            _invokeWrite = new StringSendDelegate( SendString );
        }

        public override void Write( string message )
        {
            WriteIndent();
            _target.Invoke( _invokeWrite, new object[] { message } );
        }

        public override void WriteLine( string message )
        {
            WriteIndent();
            _target.Invoke( _invokeWrite, new object[] { message + Environment.NewLine } );
        }

        protected override void WriteIndent()
        {
            _target.Invoke( _invokeWrite, new object[] { string.Empty.Fill( " ", ( this.IndentLevel * this.IndentSize ) ) } );
        }

        private delegate void StringSendDelegate( string message );
        private void SendString( string message )
        {
            // No need to lock text box as this function will only 
            // ever be executed from the UI thread
            _target.Text += message;
        }
    }
}
