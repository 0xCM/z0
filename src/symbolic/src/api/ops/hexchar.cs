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
        public static char hexchar(UpperCased @case, byte index)
            => (char)symbol(@case, (HexDigit)index);

        [MethodImpl(Inline), Op]
        public static char hexchar(LowerCased @case, byte index)
            => (char)symbol(@case, (HexDigit)index);
    }
}