//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public readonly struct X86ApiExtracts
    {
        readonly TableSpan<X86ApiExtract> Data;

        [MethodImpl(Inline)]
        public static implicit operator X86ApiExtracts(X86ApiExtract[] src)
            => new X86ApiExtracts(src);

        [MethodImpl(Inline)]
        public X86ApiExtracts(X86ApiExtract[] src)
            => Data = src;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public X86ApiExtract[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }
    }

}