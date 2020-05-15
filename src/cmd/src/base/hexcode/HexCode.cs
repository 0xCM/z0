//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct HexCode : IHexCode
    {
        public HexKind Kind {get;}

        public byte[] Data {get;}

        [MethodImpl(Inline)]
        public static implicit operator HexCode((HexKind kind, byte[] data) src)
            => new HexCode(src.kind, src.data);

        [MethodImpl(Inline)]
        public HexCode(HexKind k, byte[] value)
        {
            Kind = k;
            Data = value;
        }

        [MethodImpl(Inline)]
        public HexCode(HexKind k, ReadOnlySpan<byte> value)
        {
            Kind = k;
            Data = value.ToArray();
        }
    }
}