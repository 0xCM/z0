// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static As;

    partial class RootLegacy
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe MemoryAddress address<P>(P* pSrc)
            where P : unmanaged
                => new MemoryAddress(pSrc);

        [MethodImpl(Inline), Op]
        public static unsafe MemoryAddress address(string src)
            => address(pchar(src));


    }
}