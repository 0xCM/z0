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

    public readonly struct PrimalBitField<V,T,I,W,S,M> : IPrimalBitField<PrimalBitField<V,T,I,W,S,M>,V,T,I,W,S,M>
        where V : unmanaged, Enum
        where T : unmanaged 
        where I : unmanaged, Enum
        where W : unmanaged, Enum
        where S : unmanaged, Enum
        where M : unmanaged, Enum
    {
        public V FieldValue {get;}

        public T FieldData {get;}

        readonly M[] Masks;

        readonly I[] Indices;

        readonly S[] Segments;

        readonly W[] Widths;
        
        [MethodImpl(Inline)]
        internal PrimalBitField(V value)
        {
            FieldValue = value;
            FieldData = Enums.scalar<V,T>(value);
            Masks = Enums.literals<M>().Map(x => x.LiteralValue);
            Indices = Enums.literals<I>().Map(x => x.LiteralValue);
            Segments = Enums.literals<S>().Map(x => x.LiteralValue);
            Widths = Enums.literals<W>().Map(x => x.LiteralValue);
        }

        [MethodImpl(Inline)]
        public T Data(I index)
        {
            var pos = u8(Index(index));
            var width = u8(Width(index));
            return gbits.slice(FieldData, pos, width);
        }

        [MethodImpl(Inline)]
        public I Field(byte index) 
            => Indices[index];

        [MethodImpl(Inline)]
        public S Index(I index) 
            => Segments[u8(index)];

        [MethodImpl(Inline)]
        public W Width(I index) 
            => Widths[u8(index)];

        public M Mask(I index) 
            => Masks[u8(index)];

        [MethodImpl(Inline)]
        static byte u8(I x) => Enums.e8u(x);

        [MethodImpl(Inline)]
        static byte u8(S x) => Enums.e8u(x);

        [MethodImpl(Inline)]
        static byte u8(W x) => Enums.e8u(x);

    }    
}