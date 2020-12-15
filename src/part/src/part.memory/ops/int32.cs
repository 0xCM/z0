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
        public static int int32<T>(T src)
            => As<T,int>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static int? int32<T>(T? src)
            where T : unmanaged
                => As<T?, int?>(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref int int32<T>(ref T src)
            => ref As<T,int>(ref src);
    }
}