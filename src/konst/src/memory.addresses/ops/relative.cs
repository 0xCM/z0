//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using DW = DataWidth;

    partial struct Addresses
    {
        /// <summary>
        /// Defines a <typeparamname name='T'/> valued <see cref='RelativeAddress{T}'/> relative to a specified offset
        /// </summary>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The offset type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static RelativeAddress<T> relative<T>(T offset)
            where T : unmanaged
                => new RelativeAddress<T>(offset);

        /// <summary>
        /// Defines a <see cref='RelativeAddress'/> offset with a <see cref='byte'/> valued offset
        /// </summary>
        /// <param name="offset">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static RelativeAddress relative(byte offset)
            => new RelativeAddress(offset, DW.W8);

        /// <summary>
        /// Defines a <see cref='RelativeAddress'/> offset with a <see cref='ushort'/> valued offset
        /// </summary>
        /// <param name="offset">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static RelativeAddress relative(ushort offset)
            => new RelativeAddress(offset, DW.W16);

        /// <summary>
        /// Defines a <see cref='RelativeAddress'/> offset with a <see cref='uint'/> valued offset
        /// </summary>
        /// <param name="offset">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static RelativeAddress relative(uint offset)
            => new RelativeAddress(offset, DW.W32);
    }
}