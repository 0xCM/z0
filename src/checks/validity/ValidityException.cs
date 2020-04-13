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
        public static ValidityException Define(ValidityClaim op, IAppMsg msg)
            => new ValidityException(op, msg);        

        public ValidityException() { }
     
        ValidityException(ValidityClaim kind, IAppMsg msg) 
            : base(msg)
            { 
                this.OpKind = kind;
            }
         
        public ValidityClaim OpKind {get;}         
    }
}