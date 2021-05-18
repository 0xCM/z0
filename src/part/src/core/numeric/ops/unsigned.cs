//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Numeric
    {
        /// <summary>
        /// Returns 1 if <typeparamref name='T'/> is an unsigned integral type and 0 otherwise
        /// </summary>
        /// <typeparam name="T">The test type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static bit usigned<T>()
            where T : unmanaged
                => typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong);


        [MethodImpl(Inline), Op]
        public static byte u8(byte src)
            => src;

        [MethodImpl(Inline), Op]
        public static ushort u16(ushort src)
            => src;
    }
}