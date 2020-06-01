//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    
    using static Memories;

    public readonly ref struct BitFieldFixed<E,T,W>
        where E : unmanaged, Enum
        where T : unmanaged
        where W : unmanaged, Enum
    {
        readonly FixedData<T> Data;

        readonly BitFieldSpec<E,W> Spec;

        [MethodImpl(Inline)]
        internal BitFieldFixed(FixedData<T> data, BitFieldSpec<E,W> spec)
        {
            this.Data = data;
            this.Spec = spec;
        }

        public FixedData<T> Content
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
        public T BitSlice(byte start, byte length)
            => Data.BitSlice(start,length);

        public bit this[ByteSize offset, byte pos]        
        {
            [MethodImpl(Inline)]
            get => Data[offset,pos];
            
            [MethodImpl(Inline)]
            set => Data[offset,pos] = value;
        }

        public string Format()
            => SegmentFormatter.format(Spec.Segments);
    }
}