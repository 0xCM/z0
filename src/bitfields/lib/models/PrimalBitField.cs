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

    public readonly struct PrimalBitField<I,P,T,S,W> : IBitField<PrimalBitField<I,P,T,S,W>, I, P, T, S, W>
        where I : unmanaged, Enum
        where P : unmanaged, Enum
        where T : unmanaged
        where S : unmanaged, Enum
        where W : unmanaged, Enum
    {
        readonly I[] Indices;

        readonly P[] Positions;

        readonly W[] Widths;

        readonly T[] Cells;

        [MethodImpl(Inline)]
        internal PrimalBitField(T data)
        {
            Cells = new T[1]{data};
            Indices = Enums.index<I>().Map(x => x.LiteralValue);
            Positions = Enums.index<P>().Map(x => x.LiteralValue);
            Widths = Enums.index<W>().Map(x => x.LiteralValue);
        }

        public T Content
            => Cell;

        [MethodImpl(Inline)]
        public S Segment(I index)
            => z.cast<T,S>(gbits.slice(Cell, SegPos(index), SegWidth(index)));

        [MethodImpl(Inline)]
        public void Segment(I index, S value)
        {
            var pos = Enums.e8u(Position(index));
            var width = Enums.e8u(Width(index));
            Cell = gbits.copy(z.cast<S,T>(value), pos, width, Cell);
        }

        public S this[I index]
        {
            [MethodImpl(Inline)]
            get => Segment(index);

            [MethodImpl(Inline)]
            set => Segment(index, value);
        }

        [MethodImpl(Inline)]
        public P Position(I index)
            => Positions[Enums.e8u(index)];

        [MethodImpl(Inline)]
        public W Width(I index)
            => Widths[Enums.e8u(index)];

        [MethodImpl(Inline)]
        byte SegPos(I index)
            => Enums.e8u(Position(index));

        [MethodImpl(Inline)]
        byte SegWidth(I index)
            => Enums.e8u(Width(index));

        ref T Cell
        {
            [MethodImpl(Inline)]
            get => ref Cells[0];
        }
    }
}