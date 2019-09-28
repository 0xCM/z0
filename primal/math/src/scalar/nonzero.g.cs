//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;
    using static AsIn;

    partial class gmath
    {

        [MethodImpl(Inline)]
        public static bool nonzero<T>(T src)
            where T : unmanaged
        {
            if(isFloat32<T>())
                return math.nonzero(float32(src));
            else if(isFloat64<T>())
                return math.nonzero(float64(src));
            else
                return src.Equals(default);
        }


    }

}