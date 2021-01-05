//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    partial class Enums
    {
        /// <summary>
        /// Interprets an enum value as an unsigned 16-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ushort e16u<E>(E e)
            where E : unmanaged, Enum
                => EnumValue.e16u(e);

        /// <summary>
        /// Interprets an enum value as a signed 16-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static short e16i<E>(E e)
            where E : unmanaged, Enum
                => EnumValue.e16i(e);

        /// <summary>
        /// Reads an i16 value from an enum of primal i16-kind, writes the value to a u64 target, and returns the extracted i16 value
        /// </summary>
        /// <param name="src">The enum value</param>
        /// <param name="dst">The storage target</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref short i16<E>(in E src, ref ulong dst)
            where E : unmanaged, Enum
        {
            ref var tVal = ref z.@as<E,short>(src);
            dst = (ushort)tVal;
            return ref tVal;
        }

        /// <summary>
        /// Reads a u16 value from an enum of primal u16-kind, writes the value to a u64 target, and returns the extracted value as c16 value
        /// </summary>
        /// <param name="src">The enum value</param>
        /// <param name="dst">The storage target</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref char c16<E>(in E src, ref ulong dst)
            where E : unmanaged, Enum
                => ref @as<ushort,char>(store(w16, src, ref dst));
    }
}