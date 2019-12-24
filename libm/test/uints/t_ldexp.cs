//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_ldexp : t_libm<t_ldexp>
    {    
        [MethodImpl(Inline)]
        static double ldexp(double x, int i)
            => x * Math.Pow(2.0, i);

        
    }

}