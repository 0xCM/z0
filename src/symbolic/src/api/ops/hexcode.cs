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

    using HCU = HexDigitCodeUp;
    using HCL = HexDigitCodeLo;

    partial class Symbolic
    {
        [MethodImpl(Inline), Op]
        public static HCU hexcode(UpperCased casing, int index)
            => (HCU)skip(SymbolicData.UpperHexCodes, index);

        [MethodImpl(Inline), Op]
        public static HCL hexcode(LowerCased casing, int index)
            => (HCL)skip(SymbolicData.LowerHexCodes, index);
    }
}