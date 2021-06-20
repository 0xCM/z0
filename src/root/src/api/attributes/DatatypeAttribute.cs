//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Applied to a type to denote inclusion as a datatype within the DSL
    /// </summary>
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Delegate)]
    public class DataTypeAttribute : Attribute
    {
        public DataTypeAttribute()
        {

        }

        public DataTypeAttribute(TypeKind kind, params object[] synonyms)
        {

        }

        public DataTypeAttribute(params object[] synonyms)
        {

        }

        public TypeKind Kind{get;}
    }
}