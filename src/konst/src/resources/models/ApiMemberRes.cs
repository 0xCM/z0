//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    public readonly struct ApiMemberRes : ITextual
    {
        public readonly ApiHostUri Host;

        public readonly MethodInfo Member;

        public readonly ApiResKind Kind;

        [MethodImpl(Inline)]
        public ApiMemberRes(ApiHostUri host, MethodInfo member, ApiResKind format)
        {
            Host = host;
            Member = member;
            Kind = format;;
        }

        public Type DeclaringType
        {
            [MethodImpl(Inline)]
            get => Member?.DeclaringType ?? EmptyVessels.EmptyType;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Member == null || EmptyVessels.IsEmpty(Member) || Host.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        [MethodImpl(Inline)]
        public string Format()
            => string.Format(RP.PSx2, Host, Member.Name);
    }
}