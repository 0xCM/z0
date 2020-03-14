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

    public readonly struct Variant128 : IFixed<Variant128, Fixed128V>, IEquatable<Variant128>
    {
        readonly Fixed128V data;        

        readonly NumericKind cell;

        [MethodImpl(Inline)]
        public static Variant128 Define(Fixed128V data, NumericKind kCell)
            => new Variant128(data,kCell);

        [MethodImpl(Inline)]
        Variant128(Fixed128V data, NumericKind kCell)
        {
            this.data = data;
            this.cell = kCell;
        }

        [MethodImpl(Inline)]
        public bool Equals(Variant128 other)
            => data.Equals(other.data) && cell == other.cell;

        public override int GetHashCode()
            => HashCode.Combine(data,cell);
        
        public override bool Equals(object src)
            => src is Variant128 x && Equals(x);
    }
}