//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    
    partial class XTend
    {
        /// <summary>
        /// Determines whether a type is system-defined primitive
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSystemDefined(this Type src)
            => src.IsPrimalNumeric() || src.IsBool() || src.IsVoid() || src.IsChar() || src.IsString() || src.IsObject(); 

        /// <summary>
        /// Determines whether a supplied type is predicated on a bool, including nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsBool(this Type t)
            => t.IsTypeOf<bool>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a string, including references
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsString(this Type t)
            => t.IsTypeOf<string>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a string, including references
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsObject(this Type t)
            => t.IsTypeOf<object>();

        /// <summary>
        /// Determines whether a supplied type is of type Void
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsVoid(this Type t)
            => t == typeof(void);

        /// <summary>
        /// Determines whether a supplied type is predicated on a char, including nullable wrappers and references
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsChar(this Type src)
            => src.IsTypeOf<Char>();       
    }
}