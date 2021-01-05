//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class Enums
    {
        /// <summary>
        /// Safely, thus slowly, converts a numeric value to an enum value if and only if the numeric value
        /// is represented by a declared literal
        /// </summary>
        /// <param name="value">The numeric source value</param>
        /// <param name="default">The enum value to return if the conversion fails</param>
        [MethodImpl(Inline)]
        public static E convert<E>(byte value, E @default = default)
            where E : unmanaged, Enum
                => Option.Try(() => (E)Enum.ToObject(typeof(E), value)).ValueOrDefault(@default);

        /// <summary>
        /// Safely, thus slowly, converts a numeric value to an enum value if and only if the numeric value
        /// is represented by a declared literal
        /// </summary>
        /// <param name="value">The numeric source value</param>
        /// <param name="default">The enum value to return if the conversion fails</param>
        [MethodImpl(Inline)]
        public static E convert<E>(sbyte value, E @default = default)
            where E : unmanaged, Enum
                => Option.Try(() => (E)Enum.ToObject(typeof(E), value)).ValueOrDefault(@default);

        /// <summary>
        /// Safely, thus slowly, converts a numeric value to an enum value if and only if the numeric value
        /// is represented by a declared literal
        /// </summary>
        /// <param name="value">The numeric source value</param>
        /// <param name="default">The enum value to return if the conversion fails</param>
        [MethodImpl(Inline)]
        public static E convert<E>(short value, E @default = default)
            where E : unmanaged, Enum
                => Option.Try(() => (E)Enum.ToObject(typeof(E), value)).ValueOrDefault(@default);

        /// <summary>
        /// Safely, thus slowly, converts a numeric value to an enum value if and only if the numeric value
        /// is represented by a declared literal
        /// </summary>
        /// <param name="value">The numeric source value</param>
        /// <param name="default">The enum value to return if the conversion fails</param>
        [MethodImpl(Inline)]
        public static E convert<E>(ushort value, E @default = default)
            where E : unmanaged, Enum
                => Option.Try(() => (E)Enum.ToObject(typeof(E), value)).ValueOrDefault(@default);

        /// <summary>
        /// Safely, thus slowly, converts a numeric value to an enum value if and only if the numeric value
        /// is represented by a declared literal
        /// </summary>
        /// <param name="value">The numeric source value</param>
        /// <param name="default">The enum value to return if the conversion fails</param>
        [MethodImpl(Inline)]
        public static E convert<E>(int value, E @default = default)
            where E : unmanaged, Enum
                => Option.Try(() => (E)Enum.ToObject(typeof(E), value)).ValueOrDefault(@default);

        /// <summary>
        /// Safely, thus slowly, converts a numeric value to an enum value if and only if the numeric value
        /// is represented by a declared literal
        /// </summary>
        /// <param name="value">The numeric source value</param>
        /// <param name="default">The enum value to return if the conversion fails</param>
        [MethodImpl(Inline)]
        public static E convert<E>(uint value, E @default = default)
            where E : unmanaged, Enum
                => Option.Try(() => (E)Enum.ToObject(typeof(E), value)).ValueOrDefault(@default);

        /// <summary>
        /// Safely, thus slowly, converts a numeric value to an enum value if and only if the numeric value
        /// is represented by a declared literal
        /// </summary>
        /// <param name="value">The numeric source value</param>
        /// <param name="default">The enum value to return if the conversion fails</param>
        [MethodImpl(Inline)]
        public static E convert<E>(long value, E @default = default)
            where E : unmanaged, Enum
                => Option.Try(() => (E)Enum.ToObject(typeof(E), value)).ValueOrDefault(@default);

        /// <summary>
        /// Safely, thus slowly, converts a numeric value to an enum value if and only if the numeric value
        /// is represented by a declared literal
        /// </summary>
        /// <param name="value">The numeric source value</param>
        /// <param name="default">The enum value to return if the conversion fails</param>
        [MethodImpl(Inline)]
        public static E convert<E>(ulong value, E @default = default)
            where E : unmanaged, Enum
                => Option.Try(() => (E)Enum.ToObject(typeof(E), value)).ValueOrDefault(@default);
    }
}