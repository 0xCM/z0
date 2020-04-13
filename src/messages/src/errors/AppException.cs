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
            => Define(AppMsg.NoCaller($"{reason?.ToString()} {caller} {file} {line}", AppMsgKind.Error));

        public AppException() { }
     
        public AppException(AppMsg msg) 
            : base(msg.ToString()) 
            { 
                this.Message = Message;
            }
     
        protected AppException(SerializationInfo info, StreamingContext context) 
            : base(info, context) { }    
                
        public new AppMsg Message {get;}

        public AppMsgKind Severity
            => Message.Kind;

        public override string ToString()
            => Message.ToString();
    }
}