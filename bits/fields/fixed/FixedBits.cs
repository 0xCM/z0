//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static root;    

    public readonly ref struct FixedBits<I,T,W>
        where I : unmanaged, Enum
        where T : unmanaged
        where W : unmanaged, Enum
    {
        readonly FixedData<T> data;

        readonly BitFieldSpec<I, W> spec;

        [MethodImpl(Inline)]
        internal FixedBits(FixedData<T> data, BitFieldSpec<I, W> spec)
        {
            this.data = data;
            this.spec = spec;
        }

        public ref T this[int cell]
        {
            [MethodImpl(Inline)]
            get => ref data.Data[cell];
        }

        [MethodImpl(Inline)]
        public T BitSlice(byte start, byte length)
            => data.BitSlice(start,length);

        public bit this[ByteSize offset, byte pos]        
        {
            [MethodImpl(Inline)]
            get => data[offset,pos];
            
            [MethodImpl(Inline)]
            set => data[offset,pos] = value;
        }

        public string Format()
            => FieldSegments.format(spec.Segments);

        public string FormatBits(int? maxbits = null)
            => data.Bytes.FormatBits(maxbits ?? data.BitCount);
    }
}