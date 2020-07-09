// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct core
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe MemoryAddress locate<T>(in T src)
            => pvoid(src);
    }
}