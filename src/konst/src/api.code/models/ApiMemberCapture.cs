//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Specifies a <see cref='ApiMember'/> along with its binary represetnation
    /// </summary>
    public readonly struct ApiMemberCapture : IComparable<ApiMemberCapture>
    {
        public ApiMember Member {get;}

        public ApiCaptureBlock Code {get;}

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