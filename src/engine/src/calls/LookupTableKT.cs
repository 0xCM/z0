//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static core;

   public readonly struct LookupTable<K,T>
        where K : unmanaged
    {
        public MemoryAddress BaseAddress {get;}

        readonly uint[] Offsets;

        readonly uint[] Lengths;

        internal LookupTable(MemoryAddress @base, uint[] offsets, uint[] lengths)
        {
            BaseAddress = @base;
            Offsets = offsets;
            Lengths = lengths;
        }

        public void Assign(K index, uint offset, uint length)
        {
            seek(Offsets, bw32(index)) = offset;
            seek(Lengths, bw32(index)) = length;
        }

        public ReadOnlySpan<T> this[K index]
        {
            [MethodImpl(Inline)]
            get => Lookup(index);
        }

        [MethodImpl(Inline)]
        public unsafe ReadOnlySpan<T> Lookup(K index)
        {
            var @base = BaseAddress + uint32(skip(Offsets, bw32(index)));
            var length = uint32(skip(Lengths, bw32(index)));
            return cover(@base.Ref<T>(), length);
        }
    }
}