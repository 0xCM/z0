//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Monadic;

    partial class Enums
    {
        [MethodImpl(Inline)]
        public static E convert<E>(byte value, E @default = default)
            => Option.Try(() => (E)Enum.ToObject(typeof(E), value)).ValueOrDefault(@default);

        [MethodImpl(Inline)]
        public static E convert<E>(sbyte value, E @default = default)
            => Option.Try(() => (E)Enum.ToObject(typeof(E), value)).ValueOrDefault(@default);

        [MethodImpl(Inline)]
        public static E convert<E>(short value, E @default = default)
            => Option.Try(() => (E)Enum.ToObject(typeof(E), value)).ValueOrDefault(@default);

        [MethodImpl(Inline)]
        public static E convert<E>(ushort value, E @default = default)
            => Option.Try(() => (E)Enum.ToObject(typeof(E), value)).ValueOrDefault(@default);

        [MethodImpl(Inline)]
        public static E convert<E>(int value, E @default = default)
            => Option.Try(() => (E)Enum.ToObject(typeof(E), value)).ValueOrDefault(@default);

        [MethodImpl(Inline)]
        public static E convert<E>(uint value, E @default = default)
            => Option.Try(() => (E)Enum.ToObject(typeof(E), value)).ValueOrDefault(@default);

        [MethodImpl(Inline)]
        public static E convert<E>(long value, E @default = default)
            => Option.Try(() => (E)Enum.ToObject(typeof(E), value)).ValueOrDefault(@default);

        [MethodImpl(Inline)]
        public static E convert<E>(ulong value, E @default = default)
            => Option.Try(() => (E)Enum.ToObject(typeof(E), value)).ValueOrDefault(@default);

        /// <summary>
        /// Interprets an enum value as a signed byte
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static sbyte i8<E>(E e = default)
            where E : unmanaged, Enum
                => Enums.numeric<E,sbyte>(e);

        /// <summary>
        /// Interprets an enum value as a byte
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static byte u8<E>(E e)
            where E : unmanaged, Enum
                => Enums.numeric<E,byte>(e);

        /// <summary>
        /// Interprets an enum value as an unsigned 16-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ushort u16<E>(E e)
            where E : unmanaged, Enum
                => Enums.numeric<E,ushort>(e);

        /// <summary>
        /// Interprets an enum value as a signed 16-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static short i16<E>(E e)
            where E : unmanaged, Enum
                => Enums.numeric<E,short>(e);

        /// <summary>
        /// Interprets an enum value as a signed 32-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static int i32<E>(E e)
            where E : unmanaged, Enum
                => Enums.numeric<E,int>(e);

        /// <summary>
        /// Interprets an enum value as an unsigned 32-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static uint u32<E>(E e)
            where E : unmanaged, Enum
                => Enums.numeric<E,uint>(e);

        /// <summary>
        /// Interprets an enum value as a signed 64-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static long i64<E>(E e)
            where E : unmanaged, Enum
                => Enums.numeric<E,long>(e);

        /// <summary>
        /// Interprets an enum value as an unsigned 64-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ulong u64<E>(E e)
            where E : unmanaged, Enum
                => Enums.numeric<E,ulong>(e);
    }
}