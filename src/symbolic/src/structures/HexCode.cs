//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct HexCode : IHexCode<HexCode>
    {
        [MethodImpl(Inline)]
        public static implicit operator byte(HexCode src)
            => (byte)src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator HexKind(HexCode src)
            => src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator HexCode(byte src)
            => new HexCode((HexKind)src);

        [MethodImpl(Inline)]
        public static implicit operator HexCode(HexKind src)
            => new HexCode(src);

        [MethodImpl(Inline)]
        public HexCode(HexKind kind)
        {
            Kind = kind;
        }
        
        public HexKind Kind {get;}
    }
}