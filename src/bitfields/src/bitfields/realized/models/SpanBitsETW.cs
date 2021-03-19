//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly ref struct SpanBits<E,T,W>
        where E : unmanaged
        where T : unmanaged
        where W : unmanaged
    {
        readonly SpanBits<T> Data;

        readonly BitFieldSpec<E,W> Spec;

        [MethodImpl(Inline)]
        public SpanBits(SpanBits<T> data, BitFieldSpec<E,W> spec)
        {
            Data = data;
            Spec = spec;
        }

        public SpanBits<T> Content
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
            => BitFieldSpecs.format(Spec.Segments);
    }
}