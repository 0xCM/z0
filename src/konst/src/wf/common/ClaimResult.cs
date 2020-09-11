//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    public readonly struct ClaimResult
    {
        public readonly ClaimKind Claim;

        public readonly bool Success;

        public readonly AppMsg Message;

        [MethodImpl(Inline)]
        public static implicit operator ClaimResult(Tripled<ClaimKind,bool,AppMsg> src)
            => new ClaimResult(src.First, src.Second, src.Third);

        [MethodImpl(Inline)]
        public ClaimResult(ClaimKind claim, bool success, AppMsg message)
        {
            Claim = claim;
            Success = success;
            Message = message;
        }
    }
}