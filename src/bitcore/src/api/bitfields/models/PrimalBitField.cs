//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    public ref struct PrimalBitField<I,P,T,S,W>
        where I : unmanaged, Enum
        where P : unmanaged, Enum
        where W : unmanaged, Enum
        where S : unmanaged
        where T : unmanaged
    {
        readonly ReadOnlySpan<I> Indices;

        readonly ReadOnlySpan<P> Positions;

        readonly ReadOnlySpan<W> Widths;

        T Data;

        [MethodImpl(Inline)]
        public PrimalBitField(T data)
        {
            Data = data;
            Indices = Enums.index<I>().Map(x => x.LiteralValue);
            Positions = Enums.index<P>().Map(x => x.LiteralValue);
            Widths = Enums.index<W>().Map(x => x.LiteralValue);
        }

        public T Value
            => Data;

        [MethodImpl(Inline)]
        public S ReadSeg(I index)
            => @as<T,S>(gbits.bitslice(Data, Pos8u(index), Width8u(index)));

        [MethodImpl(Inline)]
        public void WriteSeg(I index, S value)
        {
            var pos = Pos8u(index);
            var width = Width8u(index);
            Data = gbits.copy(@as<S,T>(value), pos, width, Data);
        }

        public S this[I index]
        {
            [MethodImpl(Inline)]
            get => ReadSeg(index);

            [MethodImpl(Inline)]
            set => WriteSeg(index, value);
        }

        [MethodImpl(Inline)]
        public ref readonly P Position(in I index)
            => ref skip(Positions, Index8u(index));

        [MethodImpl(Inline)]
        public ref readonly W Width(in I index)
            => ref skip(Widths, Index8u(index));

        [MethodImpl(Inline)]
        static ref readonly byte Index8u(in I index)
            => ref @as<I,byte>(index);

        [MethodImpl(Inline)]
        ref readonly byte Pos8u(in I index)
            => ref @as<P,byte>(Position(index));

        [MethodImpl(Inline)]
        ref readonly byte Width8u(in I index)
            => ref @as<W,byte>(Width(index));
    }
}