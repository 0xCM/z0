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
        [MethodImpl(Inline), Op]
        public static unsafe MemoryAddress address(Ref src)
            => src.Location;

        /// <summary>
        /// Defines an address predicated on the leading source cell
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static unsafe MemoryAddress address(BinaryCode src)
            => address<byte>(in src.Encoded[0]);

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
        public static Address<W8,byte> address(W8 w, byte src)
            => new Address<W8,byte>(src);

        [MethodImpl(Inline), Op]
        public static Address<W16,ushort> address(W16 w, ushort src)
            => new Address<W16,ushort>(src);

        [MethodImpl(Inline), Op]
        public static Address<W32,uint> address(W32 w, uint src)
            => new Address<W32,uint>(src);

        [MethodImpl(Inline), Op]
        public static Address<W64,ulong> address(W64 w, ulong src)
            => new Address<W64,ulong>(src);

        [MethodImpl(Inline), Op]
        public unsafe static MemoryAddress address(void* p)
            => address((ulong)p);            
    }
}