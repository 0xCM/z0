//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Enums
    {
        /// <summary>
        /// Interprets an enum value as a signed 32-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static int e32i<E>(E e)
            where E : unmanaged, Enum
                => EnumValue.e32i(e);

        /// <summary>
        /// Interprets an enum value as an unsigned 32-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static uint e32u<E>(E e)
            where E : unmanaged, Enum
                => EnumValue.e32u(e);

        /// <summary>
        /// Reads an i32 value from an enum of primal i32-kind, writes the value to a u64 target, and returns the extracted i32 value
        /// </summary>
        /// <param name="src">The enum value</param>
        /// <param name="dst">The storage target</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref int i32<E>(in E src, ref ulong dst)
            where E : unmanaged, Enum
        {
            ref var tVal = ref z.@as<E,int>(src);
            dst = (uint)tVal;
            return ref tVal;
        }
    }
}