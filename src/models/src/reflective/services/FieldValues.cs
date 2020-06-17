//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct FieldValues
    {
        public static FieldValues<E,T> from<E,T>(Type src)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var tValues = src.LiteralFieldValues<T>();
            return tValues.Data.Select(x => FieldValue.from(x.Field, EnumValue.eVal<E,T>(x.Value), x.Value));
        }

        /// <summary>
        /// Selects the literal values declared by a type that are of specified parametric type
        /// </summary>
        /// <param name="src">The source type</param>
        /// <typeparam name="T">The literal value type</typeparam>
        public static FieldValues<T> from<T>(Type src)
            where T : unmanaged
                => src.LiteralFields<T>().Select(f => (f,(T)f.GetRawConstantValue()));
    }
}