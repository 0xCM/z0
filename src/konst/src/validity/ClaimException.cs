//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Raised when a validation check has failed
    /// </summary>
    [Serializable]
    public class ClaimException : AppException
    {
        public static ClaimException Define(ClaimKind op, IAppMsg msg)
            => new ClaimException(op, msg);

        public ClaimException() { }

        internal ClaimException(ClaimKind kind, IAppMsg msg)
            : base(msg)
            {
                OpKind = kind;
            }

        public ClaimKind OpKind {get;}
    }
}