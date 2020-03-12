//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    public readonly struct ApiMemberCode : IFormattable<ApiMemberCode>, INullary<ApiMemberCode>, IMethodSource<ApiMemberCode>
    {
        public static ApiMemberCode Empty => Define(HostedMember.Empty, BinaryCode.Empty);

        public readonly HostedMember Member;

        public readonly BinaryCode Code;

        public OpIdentity Id => Member.Id;

        public MethodInfo Method => Member.Method;

        public OpUri Uri => Member.Uri;

        [MethodImpl(Inline)]
        public static ApiMemberCode Define(HostedMember member, BinaryCode code)
            => new ApiMemberCode(member, code);

        [MethodImpl(Inline)]
        ApiMemberCode(HostedMember member, BinaryCode code)
        {
            this.Member = member;
            this.Code = code;            
        }

        public bool IsEmpty => Code.IsEmpty && Member.IsEmpty;

        ApiMemberCode INullary<ApiMemberCode>.Empty 
            => Empty;

        public string Format(int uripad)
            => text.concat(Member.Uri.Format().PadRight(uripad), Code.Format());

        public string Format()
            => Format(20);

        public override string ToString()
            => Format();
    }
}