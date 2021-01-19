//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ApiMemberCapture : IComparable<ApiMemberCapture>
    {
        public readonly ApiMember Member;

        public readonly ApiCaptureBlock Code;

        [MethodImpl(Inline)]
        public ApiMemberCapture(ApiMember member, ApiCaptureBlock code)
        {
            Member = member;
            Code = code;
        }

        [MethodImpl(Inline)]
        public int CompareTo(ApiMemberCapture src)
            => Code.Compare(src.Code);
    }
}