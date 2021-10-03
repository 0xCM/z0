//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public unsafe readonly struct StringRef
    {
        readonly MemoryAddress Base;

        public readonly uint Length;

        public readonly uint Hash;

        [MethodImpl(Inline)]
        public StringRef(MemoryAddress @base, uint length)
        {
            Base = @base;
            Length = length;
            Hash = alg.hash.marvin(cover(@base.Pointer<char>(), length));
        }

        public ReadOnlySpan<char> Data
        {
            [MethodImpl(Inline)]
            get => cover(Base.Pointer<char>(), Length);
        }
    }
}