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
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.Floats)]
        public static bit within<T>(T a, T b, T delta)    
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fmath.within(float32(a),float32(b), float32(delta));
            else if(typeof(T) == typeof(double))
                return fmath.within(float64(a), float64(b), float64(delta));
            else            
                throw unsupported<T>();
        }        
    }

    partial class fmath
    {
        [MethodImpl(Inline)]
        public static bit within(float a, float b, float delta)
            => a > b ? a - b <= delta 
              : b - a <= delta;

        [MethodImpl(Inline)]
        public static bit within(double a, double b, double delta)
            => a > b ? a - b <= delta 
              : b - a <= delta;
    }

}