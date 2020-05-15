//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static HexKind;


    public class HexCodes
    {
        public readonly struct X00 : IHexCode<X01> { public HexKind Kind => x00; }

        public readonly struct X01 : IHexCode<X01> { public HexKind Kind => x01; }

        public readonly struct X02 : IHexCode<X01> { public HexKind Kind => x02; }

        public readonly struct X03 : IHexCode<X01> { public HexKind Kind => x03; }

    }
}