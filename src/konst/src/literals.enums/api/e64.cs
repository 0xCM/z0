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
        /// Interprets an enum value as a signed 64-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static long e64i<E>(E e)
            where E : unmanaged, Enum
                => EnumValue.e64i(e);

        /// <summary>
        /// Interprets an enum value as an unsigned 64-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ulong e64u<E>(E e)
            where E : unmanaged, Enum
                => EnumValue.e64u(e);

        /// <summary>
        /// Reads an i64 value from an enum of primal i64-kind, writes the value to a u64 target, and returns the extracted i64 value
        /// </summary>
        /// <param name="src">The enum value</param>
        /// <param name="dst">The storage target</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref long i64<E>(in E src, ref ulong dst)
            where E : unmanaged, Enum
        {
            ref var tVal = ref z.@as<E,long>(src);
            dst = (ulong)tVal;
            return ref tVal;
        }
    }
}