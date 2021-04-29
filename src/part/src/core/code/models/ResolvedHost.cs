//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ResolvedHost : IComparable<ResolvedHost>
    {
        public ApiHostUri Host {get;}

        public Index<ResolvedMethod> Methods {get;}

        public MemoryAddress BaseAddress {get;}

        [MethodImpl(Inline)]
        public ResolvedHost(ApiHostUri uri, MemoryAddress @base, Index<ResolvedMethod> methods)
        {
            Host = uri;
            Methods = methods;
            BaseAddress = @base;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Host == null;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Host != null && Methods.IsNonEmpty;
        }

        [MethodImpl(Inline)]
        public int CompareTo(ResolvedHost src)
            => BaseAddress.CompareTo(src.BaseAddress);

        public static ResolvedHost Empty
        {
            [MethodImpl(Inline)]
            get => new ResolvedHost(ApiHostUri.Empty, default, sys.empty<ResolvedMethod>());
        }
    }
}