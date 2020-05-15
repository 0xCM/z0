//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct AddressSizeOverride : ILegacyPrefix
    {
        public LegacyPrefixKind Kind {get;}

        [MethodImpl(Inline)]
        internal static AddressSizeOverride Define(LegacyPrefixKind kind)
            => new AddressSizeOverride(kind);

        [MethodImpl(Inline)]
        public static implicit operator HexKindValue<LegacyPrefixGroup>(AddressSizeOverride src)   
            => ((HexKind)src.Kind,src.Group);

        [MethodImpl(Inline)]
        public static implicit operator LegacyPrefix(AddressSizeOverride src)   
            => src.Kind;

        [MethodImpl(Inline)]
        AddressSizeOverride(LegacyPrefixKind kind)
        {
            Kind = LegacyPrefixKind.AzO;
        }

        public LegacyPrefixGroup Group => LegacyPrefixGroup.AzO;     

        [MethodImpl(Inline)]
        public string Format()
            => Kind.ToString();

        public override string ToString()
            => Format();
    }
}