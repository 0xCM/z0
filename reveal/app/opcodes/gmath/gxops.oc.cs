//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.OpCodes
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    [OpCodeProvider]
    public static class gxops
    {
        public static bit eq_d16u(ushort a, ushort b)
            => math.eq(a,b);

        public static bit eq_g16u(ushort a, ushort b)
            => gmath.eq(a,b);

        public static bit eq_o16u(ushort a, ushort b)
            => GX.eq<ushort>().Invoke(a,b);

        public static string eq_moniker()
            => GX.eq<ushort>().Moniker;
                     
        const string name = "thename";

        public static string the_name()
            => name;

    }

}