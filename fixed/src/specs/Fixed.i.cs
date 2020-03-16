//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Characterizes a type that is naturally-parametric with natural widths that can be specified as a fixed-width
    /// </summary>
    /// <typeparam name="W">The natural width type</typeparam>
    public interface IFixedWidth<W> : IFixedWidth
        where W : unmanaged, ITypeNat
    {
        FixedWidth IFixedWidth.FixedWidth
        {
            [MethodImpl(Inline)]
            get => (FixedWidth)NatMath2.natval<W>();
        }
    }

    public interface IFixed<C,F> : IFixed<F>
        where F : unmanaged, IFixed
        where C : IFixed<C,F>
    {
        
    }

    public interface IFixedChar : IFixed
    {
        ReadOnlySpan<char> Individuals {get;}        
    }

    public interface IFixedChar<C> : IFixedChar
        where C : unmanaged    
    {
        int IFixed.FixedBitCount
        {
            [MethodImpl(Inline)]
            get => bitsize<C>();
        }
    }

    public readonly struct Fixed<F> : IFixed<Fixed<F>, F>, ISigned
        where F : unmanaged, IFixed
    {
        public readonly F Content;

        public readonly BitSize CellWidth;

        public readonly BitSize BitCount;

        public readonly int CellCount;

        public Sign Sign {get;}
        
        [MethodImpl(Inline)]        
        public static implicit operator F(Fixed<F> src)
            => src.Content;

        [MethodImpl(Inline)]        
        internal Fixed(F content, BitSize cellwidth, Sign sign)
        {
            this.Content = content;
            this.CellWidth = cellwidth;
            this.BitCount = default(F).FixedBitCount;
            this.CellCount = BitCount/CellWidth;
            this.Sign = sign;
        }
    }    
}