//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Memories
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static long int64<T>(T src)
            => As.int64(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static ref long int64<T>(ref T src)
            => ref As.int64(ref src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static long? int64<T>(T? src)
            where T : unmanaged
                => As.int64(src);
    }
}