//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static As;


    partial class zfoc
    {
        public static uint mod_const_16(uint a)
            => Mod16.mod(a);

        public static uint div_const_16(uint a)
            => Mod16.div(a);

        public static uint mod_const_25(uint a)
            => Mod25.mod(a);

        public static uint div_const_25(uint a)
            => Mod25.div(a);

        public static uint mod_const_32(uint a)
            => Mod32.mod(a);

        public static uint div_const_32(uint a)
            => Mod32.div(a);

    }

}