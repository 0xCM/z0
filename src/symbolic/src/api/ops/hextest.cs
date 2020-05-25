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
        public static bool hextest(UpperCased casing, char c)
            => false;

        [MethodImpl(Inline), Op]
        public static bool hextest(LowerCased casing, char c)
            => false;
    }
}