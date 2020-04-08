//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed; using static Memories;

    partial class gfp
    {
        [MethodImpl(Inline), Op, Closures(NumericKind.Floats)]
        public static T sqrt<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.sqrt(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.sqrt(float64(src)));
            else            
                throw Unsupported.define<T>();
        }           
    }
}
