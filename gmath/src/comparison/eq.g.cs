//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
                
    using static Core;

    partial class gmath
    {
        [MethodImpl(Inline), Eq, NumericClosures(NumericKind.Integers)]
        public static bit eq<T>(T a, T b)
            where T : unmanaged
                => Numeric.eq(a,b);

        [MethodImpl(Inline), Eqz, NumericClosures(NumericKind.Integers)]
        public static T eqz<T>(T a, T b)
            where T : unmanaged
                => gmath.mul(convert<T>((uint)gmath.eq(a,b)),ones<T>());
    }
}