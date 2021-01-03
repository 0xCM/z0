//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public ref struct StringLookup
    {
        readonly MemoryAddress Base;

        readonly Span<uint> Offsets;

        readonly Span<uint> Lengths;

        readonly uint Count;

        [MethodImpl(Inline)]
        public StringLookup(ReadOnlySpan<StringRef> src)
        {
            Count = (uint)src.Length;
            Offsets = alloc<uint>(Count);
            Lengths = alloc<uint>(Count);
            Base = skip(src,0).BaseAddress;
            for(var i=0u; i<Count; i++)
            {
                ref readonly var current = ref skip(src,i);
                seek(Offsets,i) = (uint)(current.BaseAddress - Base);
                seek(Lengths,i) = (uint)current.Length;
            }
        }

        public StringRef this[uint i]
        {
            [MethodImpl(Inline)]
            get => new StringRef(skip(Offsets,i), skip(Lengths,i));
        }
    }
}