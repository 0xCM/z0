//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CapturedMember : IComparable<CapturedMember>
    {
        public readonly ApiMember Member;

        public readonly ApiCapture Code;

        [MethodImpl(Inline)]
        public CapturedMember(ApiMember member, ApiCapture code)
        {
            Member = member;
            Code = code;
        }

        [MethodImpl(Inline)]
        public int CompareTo(CapturedMember src)
            => Code.Compare(src.Code);
    }
}