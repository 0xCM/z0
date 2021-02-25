//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Addresses
    {

        /// <summary>
        /// Defines a <see cref='RelativeAddress'/> offset with a specified offset
        /// </summary>
        /// <param name="offset">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static RelativeAddress relative(MemoryAddress @base, ulong offset)
            => new RelativeAddress(@base, offset);

        [MethodImpl(Inline)]
        public static RelativeAddress<BW,RW,B,R> relative<BW,RW,B,R>(B @base, R offset, BW bw = default, RW rw = default)
            where BW: unmanaged, INumericWidth
            where RW: unmanaged, INumericWidth
            where B: unmanaged
            where R: unmanaged
                => new RelativeAddress<BW,RW,B,R>(@base, offset);

        [MethodImpl(Inline), Op]
        public static RelativeAddress<W32,W16,uint,ushort> relative(uint @base, ushort offset)
            => relative(@base, offset, w32, w16);

        [MethodImpl(Inline), Op]
        public static RelativeAddress<W64,W8,ulong,byte> relative(ulong @base, byte offset)
            => relative(@base, offset, w64, w8);

        [MethodImpl(Inline), Op]
        public static RelativeAddress<W64,W16,ulong,ushort> relative(ulong @base, ushort offset)
            => relative(@base, offset, w64, w16);

        /// <summary>
        /// Defines a <typeparamname name='T'/> valued <see cref='RelativeAddress{T}'/> relative to a specified offset
        /// </summary>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The offset type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static RelativeAddress<T> relative<T>(MemoryAddress @base, T offset)
            where T : unmanaged
                => new RelativeAddress<T>(@base, offset);
    }
}