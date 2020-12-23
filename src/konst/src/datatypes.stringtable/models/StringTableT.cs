//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct StringTable<T>
    {
        public MemoryAddress BaseAddress {get;}

        readonly T[] Offsets;

        readonly T[] Lengths;

        internal StringTable(MemoryAddress @base, T[] offsets, T[] lengths)
        {
            BaseAddress = @base;
            Offsets = offsets;
            Lengths = lengths;
        }

        public void Assign(uint index, T offset, T length)
        {
            seek(Offsets,index) = offset;
            seek(Lengths,index) = length;
        }

        public ReadOnlySpan<char> this[uint index]
        {
            [MethodImpl(Inline)]
            get => Lookup(index);
        }

        [MethodImpl(Inline)]
        public unsafe ReadOnlySpan<char> Lookup(uint index)
        {
            var @base = BaseAddress + NumericCast.force<ulong>(skip(Offsets, index));
            var length = NumericCast.force<uint>(skip(Lengths, index));
            return cover(@base.Pointer<char>(), length);
        }
    }

}