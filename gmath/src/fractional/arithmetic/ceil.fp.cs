//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Root;    
    using static As;

    partial class gfp
    {
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static T ceil<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.ceil(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.ceil(float64(src)));
            else
                throw Unsupported.define<T>();
        }
    }
}