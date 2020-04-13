//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Serialization;
        
    /// <summary>
    /// Raised when a validation check has failed
    /// </summary>
    [Serializable]
    public class ValidityException : AppException
    {
        public static ValidityException Define(ValidityClaim op, AppMsg msg)
            => new ValidityException(op, msg);
        
        public static ValidityException Define(ValidityClaim op, string msg, string caller, string file, int? line)
            => new ValidityException(op, msg, caller, file, line);

        public ValidityException() { }
     
        ValidityException(ValidityClaim kind, AppMsg msg) 
            : base(msg)
            { 
                this.OpKind = kind;
            }

        ValidityException(ValidityClaim kind, string msg, string caller, string file, int? line) 
            : base(AppMsg.NoCaller($"{msg} {caller} {file} {line}", AppMsgKind.Error)) 
            { 
                this.OpKind = kind;
            }
     
        protected ValidityException(SerializationInfo info, StreamingContext context) 
            : base(info, context) { }
    
        public ValidityClaim OpKind {get;}         
    }
}