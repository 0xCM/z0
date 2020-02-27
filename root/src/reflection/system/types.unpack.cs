//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static ReflectionFlags;
    using static Root;

    partial class RootReflections
    {
        /// <summary>
        /// If the source type is a type reference, returns the referenced type; otherwise, returns the original type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static Type EffectiveType(this Type src)
            => src.UnderlyingSystemType.IsByRef ? src.GetElementType() : src;

        /// <summary>
        /// Returns the underlying system type if enclosed by a source type, otherwise returns the source type
        /// </summary>
        /// <param name="src">The source type</param>
        public static Type Unwrap(this Type src)
            => src.GetElementType() ?? src;

        /// <summary>
        /// If a reference type, returns the type; if a value type and not an enum, returns 
        /// the type; if an enum returns the unerlying integral type; if a nullable value type
        /// that is not an enum, returns the underlying type; if anullable enum returns the 
        /// non-nullable underlying integral type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static Type GetUnderlyingType(this Type t)
        {
            if (t.IsNullableType())
            {
                var _t = Nullable.GetUnderlyingType(t);
                return _t.IsEnum ? _t.GetEnumUnderlyingType() : _t;
            }
            else
                return t.IsEnum ? t.GetEnumUnderlyingType() : t;
        }
    }
}