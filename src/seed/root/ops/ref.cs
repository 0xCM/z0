//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static System.Runtime.CompilerServices.Unsafe;

    using static Konst;

    partial class RootLegacy
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe ref T @ref<T>(MemoryAddress src)
            => ref AsRef<T>((void*)src.Location);

        [MethodImpl(Inline), Op]
        public static unsafe StringRef @ref(string src)
            => new StringRef(memref(src));        
    }
}