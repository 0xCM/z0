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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static sbyte int8<T>(T src)
            => As<T,sbyte>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static sbyte? int8<T>(T? src)
            where T : unmanaged
                => As<T?,sbyte?>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref sbyte int8<T>(ref T src)
            => ref As<T,sbyte>(ref src);
    }
}
