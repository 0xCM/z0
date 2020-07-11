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
        [MethodImpl(Inline), Op, Closures(NumericKind.Floats)]
        public static bit within<T>(T a, T b, T delta)    
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fmath.within(float32(a),float32(b), float32(delta));
            else if(typeof(T) == typeof(double))
                return fmath.within(float64(a), float64(b), float64(delta));
            else            
                throw Unsupported.define<T>();
        }        
    }
}