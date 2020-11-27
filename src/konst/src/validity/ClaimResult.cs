//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct ClaimResult
    {
        public ClaimKind Claim {get;}

        public bool Success {get;}

        public string Message {get;}

        [MethodImpl(Inline)]
        public ClaimResult(ClaimKind claim, bool success, string message)
        {
            Claim = claim;
            Success = success;
            Message = message;
        }

        [MethodImpl(Inline)]
        public static implicit operator ClaimResult(Tripled<ClaimKind,bool,string> src)
            => new ClaimResult(src.First, src.Second, src.Third);
    }
}