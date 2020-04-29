//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    partial class Reflective
    {
        /// <summary>
        /// Determines whether a type is the sytem-defined 8-bit unsigned integer type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static bool IsByte(this Type t)
            => t.IsTypeOf<byte>();

        /// <summary>
        /// Determines whether a type the sytem-defined 8-bit signed integer type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static bool IsSByte(this Type t)
            => t.IsTypeOf<sbyte>();

        /// <summary>
        /// Determines whether a type the sytem-defined 8-bit unsigned integer type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static bool IsUInt8(this Type t)
            => t.IsTypeOf<byte>();

        /// <summary>
        /// Determines whether a type the sytem-defined 8-bit signed integer type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static bool IsInt8(this Type t)
            => t.IsTypeOf<sbyte>();

        /// <summary>
        /// Determines whether a type the sytem-defined 16-bit unsigned integer type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static bool IsUInt16(this Type t)
            => t.IsTypeOf<ushort>();

        /// <summary>
        /// Determines whether a type the sytem-defined 16-bit signed integer type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static bool IsInt16(this Type t)
            => t.IsTypeOf<short>();

        /// <summary>
        /// Determines whether a type the sytem-defined 32-bit unsigned integer type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static bool IsUInt32(this Type t)
            => t.IsTypeOf<uint>();

        /// <summary>
        /// Determines whether a type the sytem-defined 32-bit signed integer type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static bool IsInt32(this Type t)
            => t.IsTypeOf<int>();

        /// <summary>
        /// Determines whether a type the sytem-defined 64-bit unsigned integer type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static bool IsUInt64(this Type t)
            => t.IsTypeOf<ulong>();

        /// <summary>
        /// Determines whether a type the sytem-defined 64-bit signed integer type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static bool IsInt64(this Type t)
            => t.IsTypeOf<long>();

        /// <summary>
        /// Determines whether a type the sytem-defined 32-bit floating-point type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static bool IsSingle(this Type t)
            => t.IsTypeOf<float>();

        /// <summary>
        /// Determines whether a type the sytem-defined 32-bit floating-point type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static bool IsFloat32(this Type t)
            => t.IsTypeOf<float>();

        /// <summary>
        /// Determines whether a type the sytem-defined 64-bit floating-point type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static bool IsDouble(this Type t)
            => t.IsTypeOf<double>();

        /// <summary>
        /// Determines whether a type the sytem-defined 64-bit floating-point type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static bool IsFloat64(this Type t)
            => t.IsTypeOf<double>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a double, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline), Op]
        public static bool IsDecimal(this Type t)
            => t.IsTypeOf<decimal>();
    }
}