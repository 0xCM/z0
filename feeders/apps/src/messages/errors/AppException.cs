//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Serialization;
        
    public class AppException : Exception
    {
        public static AppException Define(AppMsg msg)
            => new AppException(msg);

        public static AppException Define(object reason, string caller, string file, int? line)
            => new AppException(reason?.ToString() ?? string.Empty, caller, file, line);

        public AppException() { }
     
        public AppException(AppMsg msg) 
            : base(msg.ToString()) 
            { 
                this.Message = msg.AsKind(AppMsgKind.Error);
                this.Caller = Message.Caller;
                this.File = Message.CallerFile;
                this.Line = Message.FileLine;
            }

        public AppException(string msg, string caller, string file, int? line) 
            : base(msg.ToString()) 
            { 
                this.Message = AppMsg.Error($"{caller} line {line} {file}: {msg}", caller, file, line);
                this.Caller = Message.Caller;
                this.File = Message.CallerFile;
                this.Line = Message.FileLine;
            }
     
        protected AppException(SerializationInfo info, StreamingContext context) 
            : base(info, context) { }    
        
        public string Caller {get;}

        public FilePath File {get;}

        public int? Line {get;}
        
        public new AppMsg Message {get;}

        public AppMsgKind Severity
            => Message.Kind;

        public override string ToString()
            => Message.ToString();
    }
}