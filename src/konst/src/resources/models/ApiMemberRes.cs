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
        public ApiHostUri Host {get;}

        public MethodInfo Member {get;}

        public ApiResKind Kind {get;}

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