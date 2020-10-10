// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static AsDeprecated;

    partial class Root
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe MemoryAddress address<P>(P* pSrc)
            where P : unmanaged
                => new MemoryAddress(pSrc);

        [MethodImpl(Inline), Op]
        public static unsafe MemoryAddress address(string src)
            => address(pchar(src));

        [MethodImpl(Inline), Op]
        public static MemoryAddress address(IntPtr src)
            => new MemoryAddress((ulong)src.ToInt64());
    }
}