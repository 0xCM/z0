//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Marks a type as an api data type
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class ApiDataTypeAttribute : ApiClassAttribute
    {
        public string Name {get;}

        public ApiDataTypeAttribute()
            : base(ApiClassKind.ApiDataType)
        {
            Name = string.Empty;
        }

        public ApiDataTypeAttribute(string name)
            : base(ApiClassKind.ApiDataType)
        {
            Name = name;
        }
    }
}