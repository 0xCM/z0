//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    public readonly struct SpanResAccessor : ITextual
    {
        public ApiHostUri Host {get;}

        public MethodInfo Member {get;}

        public SpanResKind Kind {get;}

        [MethodImpl(Inline)]
        public SpanResAccessor(ApiHostUri host, MethodInfo member, SpanResKind format)
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