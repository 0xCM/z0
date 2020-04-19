//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    /// <summary>
    /// Raised when a validation check has failed
    /// </summary>
    [Serializable]
    public class ClaimException : AppException
    {
        public static ClaimException Define(ClaimKind op, IAppMsg msg)
            => new ClaimException(op, msg);        

        public ClaimException() { }
     
        ClaimException(ClaimKind kind, IAppMsg msg) 
            : base(msg)
            { 
                this.OpKind = kind;
            }
         
        public ClaimKind OpKind {get;}         
    }    
}