//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class gfp
    {
        [MethodImpl(Inline), Closures(NumericKind.Floats)]
        public static T round<T>(T src, int scale)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(math.round(float32(src), scale));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.round(float64(src), scale));
            else
                return src;
        }
    }

}