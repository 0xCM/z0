//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static As;

    partial struct Addressable
    {
        [MethodImpl(Inline), Op]
        public static unsafe MemoryAddress address<T>(in T src)
            => new MemoryAddress(pvoid(src));

        /// <summary>
        /// Defines an address predicated on the leading source cell
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline)]
        public static unsafe MemoryAddress address<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => gptr(first(src));                

        [MethodImpl(Inline), Op]
        public static MemoryAddress address(ulong src)
            => new MemoryAddress(src);

        [MethodImpl(Inline), Op]
        public static Address8 address(W8 w, byte src)
            => new Address8(src);

        [MethodImpl(Inline), Op]
        public static Address16 address(W16 w, ushort src)
            => new Address16(src);

        [MethodImpl(Inline), Op]
        public static Address32 address(W32 w, uint src)
            => new Address32(src);

        [MethodImpl(Inline), Op]
        public static Address64 address(W64 w, ulong src)
            => new Address64(src);

        [MethodImpl(Inline), Op]
        public unsafe static MemoryAddress address(void* p)
            => address((ulong)p);            
    }
}