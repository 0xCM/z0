//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct memory
    {
        /// <summary>
        /// Interprets an enum value as an unsigned 8-bit integer, and conversly
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref byte e8u<E>(in E e)
            where E : unmanaged, Enum
                => ref EnumValue.e8u(e);

        /// <summary>
        /// Interprets an enum value as a signed 8-bit integer, and conversly
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref sbyte e8i<E>(in E e)
            where E : unmanaged, Enum
                => ref EnumValue.e8i(e);
    }
}