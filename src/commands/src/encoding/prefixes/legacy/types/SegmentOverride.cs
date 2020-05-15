//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct SegmentOverride : ILegacyPrefix
    {
        public LegacyPrefixKind Kind {get;}        

        [MethodImpl(Inline)]
        internal static SegmentOverride Define(LegacyPrefixKind kind)
            => new SegmentOverride(kind);

        [MethodImpl(Inline)]
        public static implicit operator HexKindValue<LegacyPrefixGroup>(SegmentOverride src)   
            => ((HexKind)src.Kind,src.Group);
        
        [MethodImpl(Inline)]
        public static implicit operator LegacyPrefix(SegmentOverride src)   
            => src.Kind;

        [MethodImpl(Inline)]
        SegmentOverride(LegacyPrefixKind kind)
        {
            Kind = kind;
        }

        public LegacyPrefixGroup Group 
            => LegacyPrefixGroup.SO;

        [MethodImpl(Inline)]
        public string Format()
            => Kind.ToString();

        public override string ToString()
            => Format();
    }
}