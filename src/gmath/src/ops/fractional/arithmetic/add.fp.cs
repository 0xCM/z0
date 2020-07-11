//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst; 
    using static z;

    partial class gfp
    {
        [MethodImpl(Inline), Add, Closures(Floats)]
        public static T add<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.add(float32(a), float32(b)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.add(float64(a), float64(b)));
            else            
                throw Unsupported.define<T>();
        }
    }
}