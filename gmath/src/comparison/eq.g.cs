//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
                
    using static Seed; using static Memories;

    partial class gmath
    {
        [MethodImpl(Inline), Eq, Closures(Integers)]
        public static bit eq<T>(T a, T b)
            where T : unmanaged
                => Numeric.eq(a,b);

        [MethodImpl(Inline), Eqz, Closures(Integers)]
        public static T eqz<T>(T a, T b)
            where T : unmanaged
                => gmath.mul(convert<T>((uint)gmath.eq(a,b)),ones<T>()); 
    }
}