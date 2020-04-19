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
        public new IAppMsg Message {get;}

        public static AppException Define(IAppMsg msg)
            => new AppException(msg);

        public static AppException Define(object reason, string caller, string file, int? line)
            => Define(AppMsg.NoCaller($"{reason?.ToString()} {caller} {file} {line}", AppMsgKind.Error));

        public AppException() { }
     
        public AppException(IAppMsg src) 
            : base(src.Format()) 
        { 
            this.Message = src;
        }
          
        public override string ToString()
            => Message.ToString();
    }
}