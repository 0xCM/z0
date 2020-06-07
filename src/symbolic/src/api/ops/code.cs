//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Control;
    using static Typed;

    partial class Symbolic
    {                         
        [MethodImpl(Inline), Op]
        public static HexCode code(Base16 @base, UpperCased @case, byte index)
            => (HexCode)skip(SymbolicData.UpperHexCodes, index);

        [MethodImpl(Inline), Op]
        public static HexCode code(Base16 @base, LowerCased @case, byte index)
            => (HexCode)skip(SymbolicData.LowerHexCodes, index);
    }
}