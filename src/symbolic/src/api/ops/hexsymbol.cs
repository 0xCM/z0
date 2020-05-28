//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Control;

    using HSU = HexSymbolUp;
    using HSL = HexSymbolLo;

    partial class Symbolic
    {
        [MethodImpl(Inline), Op]
        public static HSU hexsymbol(UpperCased casing, byte index)
            => skip(SymbolicData.UpperHexSymbols, index);

        [MethodImpl(Inline), Op]
        public static HSL hexsymbol(LowerCased casing, byte index)
            => skip(SymbolicData.LowerHexSymbols, index);
    }
}