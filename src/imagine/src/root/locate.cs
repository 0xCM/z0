// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static As;

    partial class Root
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe MemoryAddress locate<T>(in T src)
            => core.pvoid(src);
    }
}