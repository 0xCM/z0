//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct RepeatPrefix : ILegacyPrefix
    {
        public LegacyPrefixKind Kind {get;}        

        [MethodImpl(Inline)]
        internal static RepeatPrefix Define(LegacyPrefixKind kind)
            => new RepeatPrefix(kind);

        [MethodImpl(Inline)]
        public static implicit operator HexKindValue<LegacyPrefixGroup>(RepeatPrefix src)   
            => ((HexKind)src.Kind,src.Group);
        
        [MethodImpl(Inline)]
        public static implicit operator LegacyPrefix(RepeatPrefix src)   
            => src.Untyped;

        [MethodImpl(Inline)]
        RepeatPrefix(LegacyPrefixKind kind)
        {
            Kind = kind;
        }

        public LegacyPrefixGroup Group 
            => LegacyPrefixGroup.Repeat;

        public LegacyPrefix Untyped
        {
            [MethodImpl(Inline)]
            get => new LegacyPrefix(Kind);
        }

        [MethodImpl(Inline)]
        public string Format()
            => Kind.ToString();

        public override string ToString()
            => Format();
    }
}