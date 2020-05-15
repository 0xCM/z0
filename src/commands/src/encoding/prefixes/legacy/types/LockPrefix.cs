//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct LockPrefix : ILegacyPrefix
    {
        public LegacyPrefixKind Kind {get;}

        [MethodImpl(Inline)]
        internal static LockPrefix Define(LegacyPrefixKind kind)
            => new LockPrefix(kind);

        [MethodImpl(Inline)]
        public static implicit operator HexKindValue<LegacyPrefixGroup>(LockPrefix src)   
            => ((HexKind)src.Kind,src.Group);

        [MethodImpl(Inline)]
        public static implicit operator LegacyPrefix(LockPrefix src)   
            => src.Kind;
        
        [MethodImpl(Inline)]
        LockPrefix(LegacyPrefixKind kind)
        {
            Kind = LegacyPrefixKind.LOCK;
        }

        public LegacyPrefixGroup Group 
            => LegacyPrefixGroup.Lock;

        [MethodImpl(Inline)]
        public string Format()
            => Kind.ToString();

        public override string ToString()
            => Format();
    }
}