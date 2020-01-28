//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    partial class gfp
    {
        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.Floats)]
        public static bit nonzero<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return math.nonzero(float32(a));
            else if(typeof(T) == typeof(double))
                return math.nonzero(float64(a));
            else            
                throw unsupported<T>();
        }
    }
}