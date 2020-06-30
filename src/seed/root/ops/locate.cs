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
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe MemoryAddress locate<T>(in T src)
            => pvoid(src);
    }
}