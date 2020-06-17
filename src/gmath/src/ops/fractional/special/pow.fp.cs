//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst; using static Memories;

    partial class gfp
    {
        [MethodImpl(Inline), Closures(NumericKind.Floats)]
        public static T pow<T>(T b, uint exp)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
               return generic<T>(fmath.pow(float32(b), exp));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.pow(float64(b), exp));
            else            
               throw Unsupported.define<T>();            
        }
    }
}