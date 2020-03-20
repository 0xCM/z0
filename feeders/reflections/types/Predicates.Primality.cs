//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Linq.Expressions;

    using static ReflectionFlags;
    
    partial class Reflections
    {
        /// <summary>
        /// Determines whether a supplied type is predicated on a double, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsDecimal(this Type t)
            => t.IsTypeOf<decimal>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a bool, including nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsBool(this Type t)
            => t.IsTypeOf<bool>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a string, including references
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsString(this Type t)
            => t.IsTypeOf<string>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a string, including references
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsObject(this Type t)
            => t.IsTypeOf<object>();

        /// <summary>
        /// Determines whether a supplied type is of type Void
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVoid(this Type t)
            => t == typeof(void);

        /// <summary>
        /// Determines whether a supplied type is predicated on a char, including nullable wrappers and references
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static bool IsChar(this Type src)
            => src.IsTypeOf<Char>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a byte, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsByte(this Type t)
            => t.IsTypeOf<byte>();

        /// <summary>
        /// Determines whether a supplied type is predicated on an sbyte, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsSByte(this Type t)
            => t.IsTypeOf<sbyte>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a ushort, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsUInt16(this Type t)
            => t.IsTypeOf<ushort>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a short, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsInt16(this Type t)
            => t.IsTypeOf<short>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a uint, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsUInt32(this Type t)
            => t.IsTypeOf<uint>();

        /// <summary>
        /// Determines whether a supplied type is predicated on an int, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsInt32(this Type t)
            => t.IsTypeOf<int>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a ulong, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsUInt64(this Type t)
            => t.IsTypeOf<ulong>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a long, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsInt64(this Type t)
            => t.IsTypeOf<long>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a float, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsSingle(this Type t)
            => t.IsTypeOf<float>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a double, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsDouble(this Type t)
            => t.IsTypeOf<double>();
    }
}