//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct OperandSizeOverride : ILegacyPrefix
    {
        public LegacyPrefixKind Kind {get;}

        [MethodImpl(Inline)]
        internal static OperandSizeOverride Define(LegacyPrefixKind kind)
            => new OperandSizeOverride(kind);

        [MethodImpl(Inline)]
        public static implicit operator HexKindValue<LegacyPrefixGroup>(OperandSizeOverride src)   
            => ((HexKind)src.Kind,src.Group);

        [MethodImpl(Inline)]
        public static implicit operator LegacyPrefix(OperandSizeOverride src)   
            => src.Kind;
        
        [MethodImpl(Inline)]
        OperandSizeOverride(LegacyPrefixKind src)
        {
            Kind = LegacyPrefixKind.OzO;
        }

        public LegacyPrefixGroup Group => LegacyPrefixGroup.OzO;

        [MethodImpl(Inline)]
        public string Format()
            => Kind.ToString();

        public override string ToString()
            => Format();
    }
}