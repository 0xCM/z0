//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public readonly struct BitFieldSpec<E> : IBitFieldSpec<E>, IFormattable<BitFieldSpec<E>>
        where E : unmanaged, Enum
    {        
        readonly BitFieldSegment[] segments;

        [MethodImpl(Inline)]
        internal BitFieldSpec(BitFieldSegment[] fields)
        {
            this.segments = fields;
        }

        [MethodImpl(Inline)]
        public ref readonly BitFieldSegment Segment(byte index)
            => ref Segments[index];

        public ref readonly BitFieldSegment this[byte i]
        {
            [MethodImpl(Inline)]
            get => ref Segment(i);
        }

        public byte FieldCount
        {
            [MethodImpl(Inline)]
            get => (byte)segments.Length;
        }

        public ReadOnlySpan<BitFieldSegment> Segments 
        {
            [MethodImpl(Inline)]
            get => segments;
        }

        public string Format()
            => BitField.format(this);

        [MethodImpl(Inline)]
        public BitFieldReader<E,T> Reader<T>()
            where T : unmanaged
                => new BitFieldReader<E,T>(this);

        public override string ToString()
            => Format();
                        
   }    
}