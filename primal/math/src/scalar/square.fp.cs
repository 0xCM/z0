//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
        
    using static As;
    using static AsIn;
    using static zfunc;

    partial class fmath
    {

        [MethodImpl(Inline)]
        public static float square(float src)
            => fmath.mul(src,src);

        [MethodImpl(Inline)]
        public static double square(double src)
            => fmath.mul(src,src);


        [MethodImpl(Inline)]
        public static ref float square(ref float src)
        {
            src *= src;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref double square(ref double src)
        {
            src *= src;
            return ref src;
        }



    }
}