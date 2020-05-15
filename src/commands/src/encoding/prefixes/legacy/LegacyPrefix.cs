//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct LegacyPrefix
    {
        public LegacyPrefixKind Kind {get;}        
        
        [MethodImpl(Inline)]
        public static implicit operator LegacyPrefix(LegacyPrefixKind src)
            => new LegacyPrefix(src);

        [MethodImpl(Inline)]
        public LegacyPrefix(LegacyPrefixKind code)
        {
            Kind = code;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Kind.ToString();

        public override string ToString()
            => Format();
    }
}