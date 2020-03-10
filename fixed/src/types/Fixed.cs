//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;

    using static Root;

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