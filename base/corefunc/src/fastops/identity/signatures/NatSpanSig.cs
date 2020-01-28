//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public readonly struct NatSpanSig : IEquatable<NatSpanSig>
    {
        public static NatSpanSig Define(int length, int cellwidth, char indicator)
            => new NatSpanSig(length, cellwidth, indicator);

        public NatSpanSig(int length, int cellwidth, char indicator)
        {
            this.Length = length;
            this.CellWidth = cellwidth;
            this.Indicator = indicator;
        }

        public readonly int Length;
        
        public readonly int CellWidth;

        public readonly char Indicator;

        public override int GetHashCode()
            => HashCode.Combine(Length,CellWidth,Indicator);
        
        public bool Equals(NatSpanSig src)
            => Length == src.Length && CellWidth == src.CellWidth && Indicator == src.Indicator;
        
        public override bool Equals(object obj)
            => obj is NatSpanSig s && Equals(s);
        
        public override string ToString()
            => concat(Moniker.NatIndicator, Length.ToString(), Moniker.SegSep, CellWidth.ToString(), Indicator);
    }
}