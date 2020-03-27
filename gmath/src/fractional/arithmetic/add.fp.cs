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

        [MethodImpl(Inline), Add, NumericClosures(NumericKind.Floats)]
        public static T add<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.add(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.add(float64(lhs), float64(rhs)));
            else            
                throw Unsupported.define<T>();
        }
    }
}