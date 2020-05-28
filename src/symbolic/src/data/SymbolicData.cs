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

    partial class SymbolicData
    {
        [MethodImpl(Inline), Op]
        public static HexCode code(Base16 @base, UpperCased @case, byte index)
            => (HexCode)skip(UpperHexCodes, index);

        [MethodImpl(Inline), Op]
        public static HexCode code(Base16 @base, LowerCased @case, byte index)
            => (HexCode)skip(LowerHexCodes, index);

        [MethodImpl(Inline), Op]
        public static HexSymbol symbol(Base16 @base, UpperCased @case, byte index)
            => (HexSymbol)code(@base, @case, index);

        [MethodImpl(Inline), Op]
        public static HexSymbol symbol(Base16 @base, LowerCased @case, byte index)
            => (HexSymbol)code(@base, @case, index);

        [MethodImpl(Inline), Op]
        public static char character(Base16 @base, UpperCased @case, byte index)
            => (char)code(@base,@case,index);

        [MethodImpl(Inline), Op]
        public static char character(Base16 @base, LowerCased @case, byte index)
            => (char)code(@base,@case,index);
    }
}