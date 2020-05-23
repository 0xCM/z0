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
        public static char hexchar(UpperCased casing, int index)
            => (char)hexsymbol(casing, index);

        [MethodImpl(Inline), Op]
        public static char hexchar(LowerCased casing, int index)
            => (char)hexsymbol(casing, index);
    }
}