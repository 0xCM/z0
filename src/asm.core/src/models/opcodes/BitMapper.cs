//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct BitMapper<I,T>
        where I : unmanaged
        where T : unmanaged
    {
        readonly Index<I,BitMap<I,T>> Storage;

        public BitMapper(uint capacity)
        {
            Storage = alloc<BitMap<I,T>>(capacity);
        }

        public BitMapper(BitMap<I,T>[] maps)
        {
            Storage = maps;
        }

        [MethodImpl(Inline)]
        public ref BitMap<I,T> Map(I index)
            => ref Storage[index];

        public ref BitMap<I,T> this[I index]
        {
            [MethodImpl(Inline)]
            get => ref Map(index);
        }

        public Span<BitMap<I,T>> Points
        {
            [MethodImpl(Inline)]
            get => Storage.Edit;
        }

        public uint PointCount
        {
            [MethodImpl(Inline)]
            get => Storage.Count;
        }
    }

}