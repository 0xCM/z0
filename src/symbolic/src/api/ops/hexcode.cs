//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    
    partial class Symbolic
    {
        [MethodImpl(Inline), Op]
        public static HexCode hexcode(UpperCased @case, byte index)
            => code(base16, @case, index);

        [MethodImpl(Inline), Op]
        public static HexCode hexcode(LowerCased @case, byte index)
            => code(base16, @case, index);
    }
}