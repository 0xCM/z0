//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct LegacyPrefix
    {
        public HexKind Code {get;}        
        
        [MethodImpl(Inline)]
        public static implicit operator LegacyPrefix(HexKind src)
            => new LegacyPrefix(src);

        [MethodImpl(Inline)]
        public LegacyPrefix(HexKind code)
        {
            Code = code;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Code.ToString();

        public override string ToString()
            => Format();
    }
}