//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Presents a uint64 as an address
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static MemoryAddress address(ulong src)
            => new MemoryAddress(src);

        /// <summary>
        /// Extracts the address captured by a <see cref='StringRef'/>
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        public static ref ulong address(in StringRef src)
            => ref @as<StringRef,ulong>(src);

        /// <summary>
        /// Defines an address predicated on the leading source cell
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static MemoryAddress address(Ref src)
            => src.Location;

        /// <summary>
        /// Returns the address of the first character in the source string
        /// </summary>
        /// <param name="src">The source string</param>
        [MethodImpl(Inline), Op]
        public static unsafe MemoryAddress address(string src)
            => address(pchar(src));
            
        /// <summary>
        /// Determines the address of a reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe MemoryAddress address<T>(in T src)
            => new MemoryAddress(pvoid(src));

        /// <summary>
        /// Determines the address of the leading source cell
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op]
        public static unsafe MemoryAddress address<T>(T[] src)
            => address<T>(in src[0]);

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