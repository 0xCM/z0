//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static RootShare;

    public readonly partial struct SegmentedIdentity : ITypeIdentity<SegmentedIdentity>
    {        
        public readonly FixedWidth TotalWidth;

        public readonly FixedWidth SegWidth;

        public readonly NumericIndicator Indicator;

        public string Identifier {get;}

        public static SegmentedIdentity Empty => Define(FixedWidth.None, FixedWidth.None, NumericClass.None);

        [MethodImpl(Inline)]
        public static SegmentedIdentity Define(FixedWidth total, FixedWidth segment, NumericClass @class)
            => new SegmentedIdentity(total,segment,@class);

        [MethodImpl(Inline)]
        public static SegmentedIdentity Define(FixedWidth total, FixedWidth segment, NumericIndicator indicator)
            => new SegmentedIdentity(total,segment, indicator);

        [MethodImpl(Inline)]
        SegmentedIdentity(FixedWidth dominant, FixedWidth segwidth, NumericClass @class)
        {
            this.TotalWidth = dominant;
            this.SegWidth = segwidth;
            this.Indicator = @class.ToNumericIndicator();
            var empty = TotalWidth.IsNone() && SegWidth.IsNone() && Indicator.IsNone();
            this.Identifier = empty ? string.Empty : $"{(int)TotalWidth}{TypeIdentity.SegSep}{(int)SegWidth}{(char)Indicator}";            
        }

        [MethodImpl(Inline)]
        SegmentedIdentity(FixedWidth dominant, FixedWidth segwidth, NumericIndicator indicator)
        {
            this.TotalWidth = dominant;
            this.SegWidth = segwidth;
            this.Indicator = indicator;
            var empty = TotalWidth.IsNone() && SegWidth.IsNone() && Indicator.IsNone();
            this.Identifier = empty ? string.Empty : $"{(int)TotalWidth}{TypeIdentity.SegSep}{(int)SegWidth}{(char)Indicator}";
        }

            
        [MethodImpl(Inline)]
        public bool Equals(TypeIdentity src)
            => IdentityEquals(this, src);

        public override string ToString()
            => Identifier;
 
        public override int GetHashCode()
            => IdentityHashCode(this);

        public override bool Equals(object obj)
            => IdentityEquals(this, obj);
    }
}