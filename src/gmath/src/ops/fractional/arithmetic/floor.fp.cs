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
        public static T floor<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.floor(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.floor(float64(src)));
            else
                throw Unsupported.define<T>();
        }        
    }
}