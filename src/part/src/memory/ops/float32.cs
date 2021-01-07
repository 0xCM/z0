//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.CompilerServices.Unsafe;
    using static Part;

    partial struct memory
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static float float32<T>(T src)
            => As<T,float>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref float float32<T>(ref T src)
            => ref As<T,float>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static float? float32<T>(T? src)
            where T : unmanaged
                => As<T?,float?>(ref src);
    }
}