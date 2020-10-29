//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XReflex
    {
        /// <summary>
        /// If a value type and not an enum, returns the type;
        /// If an enum returns the underlying integral type;
        /// If a nullable value typethat is not an enum, returns the underlying type;
        /// if nullable enum, returns the non-nullable underlying integral type
        /// If a pointer returns the pointer type
        /// Otherwise, returns the effective type
        /// </summary>
        /// <param name="src">The type to examine</param>
        [Op]
        public static Type RootType(this Type src)
        {
            if(src.IsNullableType())
            {
                var tNullable = src.TNullableBase();
                return tNullable.IsEnum
                    ? tNullable.TEnumBase()
                    : tNullable;
            }
            else if(src.IsEnum)
                return src.TEnumBase();
            else if(src.IsPointer)
                return src.TPointer();
            else
                return src.TEffective();
        }
    }
}