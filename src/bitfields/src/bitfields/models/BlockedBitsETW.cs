//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly ref struct BlockedBits<E,T,W>
        where E : unmanaged
        where T : unmanaged
        where W : unmanaged
    {
        readonly BlockedBits<T> Data;

        readonly BitfieldSpec<E,W> Spec;

        [MethodImpl(Inline)]
        public BlockedBits(BlockedBits<T> data, BitfieldSpec<E,W> spec)
        {
            Data = data;
            Spec = spec;
        }

        public BlockedBits<T> Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref T this[int cell]
        {
            [MethodImpl(Inline)]
            get => ref Data.Data[cell];
        }

        [MethodImpl(Inline)]
        public T Slice(byte start, byte length)
            => Data.Slice(start, length);

        public bit this[ByteSize offset, byte pos]
        {
            [MethodImpl(Inline)]
            get => Data[offset,pos];

            [MethodImpl(Inline)]
            set => Data[offset,pos] = value;
        }

        public string Format()
            => BitfieldSpecs.format(Spec.Segments);
    }
}