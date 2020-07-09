//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct core
    {
        [MethodImpl(Inline), Op]
        public static MemoryAddress address(IntPtr src)
            => new MemoryAddress((ulong)src.ToInt64());
        
        [MethodImpl(Inline), Op]
        public static MemoryAddress address(ulong src)
            => new MemoryAddress(src);

        /// <summary>
        /// Defines an address predicated on the leading source cell
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static MemoryAddress address(Ref src)
            => src.Location;

        [MethodImpl(Inline), Op]
        public static unsafe MemoryAddress address(string src)
            => address(pchar(src));

        /// <summary>
        /// Defines an address predicated on the leading source cell
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static unsafe MemoryAddress address(byte[] src)
            => address<byte>(in src[0]);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe MemoryAddress address<T>(in T src)
            => new MemoryAddress(pvoid(src));

        [MethodImpl(Inline), Op]
        public unsafe static MemoryAddress address(void* p)
            => address((ulong)p);            

        /// <summary>
        /// Defines an address predicated on the leading source cell
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline)]
        public static unsafe MemoryAddress address<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => gptr(first(src));                

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe MemoryAddress address<P>(P* pSrc)
            where P : unmanaged
                => new MemoryAddress(pSrc);
    }
}