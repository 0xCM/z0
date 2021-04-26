//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ResolvedMethod : ITextual, IComparable<ResolvedMethod>
    {
        public OpUri Uri {get;}

        public MethodInfo Method {get;}

        public MemoryAddress Address {get;}

        [MethodImpl(Inline)]
        public ResolvedMethod(OpUri uri, MethodInfo method, MemoryAddress address)
        {
            Uri = uri;
            Method = method;
            Address = address;
        }

        [MethodImpl(Inline)]
        public ResolvedMethod(MethodInfo method, OpUri uri, MemoryAddress address)
        {
            Uri = uri;
            Method = method;
            Address = address;
        }

        public string Format()
            => Uri.UriText;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public int CompareTo(ResolvedMethod src)
            => Address.CompareTo(src.Address);
    }
}