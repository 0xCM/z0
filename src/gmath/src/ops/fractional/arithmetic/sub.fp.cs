//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst; 
    using static Memories;

    partial class gfp
    {

        [MethodImpl(Inline), Op, Closures(NumericKind.Floats)]
        public static T sub<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.sub(float32(a), float32(b)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.sub(float64(a), float64(b)));
            else            
                throw Unsupported.define<T>();
        }
    }
}