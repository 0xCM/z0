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

    partial class Symbolic    
    {        
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(ReadOnlySpan<BinarySymbol> src)
            => cast<BinarySymbol,char>(src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(ReadOnlySpan<HexSymbol> src)
            => cast<HexSymbol,char>(src);
    }
}