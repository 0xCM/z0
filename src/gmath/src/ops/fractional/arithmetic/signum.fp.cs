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
        [MethodImpl(Inline), Op, Closures(Floats)]
        public static SignKind signum<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fmath.signum(float32(src));
            else if(typeof(T) == typeof(double))
                return fmath.signum(float64(src));
            else            
                throw Unsupported.define<T>();
        }           
    }
}