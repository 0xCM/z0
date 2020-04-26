//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    partial class Reflective
    {
        /// <summary>
        /// If a value type and not an enum, returns the type; 
        /// If an enum returns the unerlying integral type; 
        /// If a nullable value typethat is not an enum, returns the underlying type; 
        /// if nullable enum, returns the non-nullable underlying integral type
        /// If a pointer returns the pointee type
        /// Otherwise, reurns the effective type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static Type RootType(this Type t)
        {
            if (t.IsNullableType())
            {
                var _t = Nullable.GetUnderlyingType(t);
                return _t.IsEnum ? _t.GetEnumUnderlyingType() : _t;
            }
            else if(t.IsEnum)
                return t.GetEnumUnderlyingType();
            else if(t.IsPointer)
                return t.GetElementType() ?? typeof(void);
            else
                return t.EffectiveType();
        }
    }
}