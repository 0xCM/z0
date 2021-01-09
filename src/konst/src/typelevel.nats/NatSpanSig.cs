//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;

    using api = NatSpans;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct NatSpanSig : IEquatable<NatSpanSig>, ITextual
    {
        public readonly uint Length;

        public readonly ushort CellWidth;

        public readonly AsciChar Indicator;

        [MethodImpl(Inline)]
        public NatSpanSig(uint length, ushort cellwidth, AsciChar indicator)
        {
            Length = length;
            CellWidth = cellwidth;
            Indicator = indicator;
        }


        public override int GetHashCode()
            => (int)api.hash(this);

        public bool Equals(NatSpanSig src)
            => api.eq(this,src);

        public override bool Equals(object obj)
            => obj is NatSpanSig s && Equals(s);
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}