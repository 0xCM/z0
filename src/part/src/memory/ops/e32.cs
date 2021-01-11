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
        /// Interprets an enum value as an unsigned 32-bit integer, and conversly
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref uint e32u<E>(in E e)
            where E : unmanaged, Enum
                => ref EnumValue.e32u(e);

        /// <summary>
        /// Interprets an enum value as a signed 32-bit integer, and conversly
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref int e32i<E>(in E e)
            where E : unmanaged, Enum
                => ref EnumValue.e32i(e);
    }
}