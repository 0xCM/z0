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
        /// Interprets an enum value as a signed byte
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static sbyte e8i<E>(E e = default)
            where E : unmanaged, Enum
                => EnumValue.e8i(e);

        /// <summary>
        /// Interprets an enum value as a byte
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static byte e8u<E>(E e)
            where E : unmanaged, Enum
                => EnumValue.e8u(e);

        /// <summary>
        /// Reads a u8 value from an enum of primal i8-kind, writes the value to a u64 target, and returns the extracted i8 value
        /// </summary>
        /// <param name="src">The enum value</param>
        /// <param name="dst">The storage target</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref sbyte i8<E>(in E src, ref ulong dst)
            where E : unmanaged, Enum
        {
            ref var tVal = ref z.@as<E,sbyte>(src);
            dst = (byte)tVal;
            return ref tVal;
        }
    }
}