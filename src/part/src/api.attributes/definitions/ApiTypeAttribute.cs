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
    public class ApiTypeAttribute : ApiProviderAttribute
    {
        public string Name {get;}

        public ApiTypeAttribute()
            : base(ApiProviderKind.DataType)
        {
            Name = string.Empty;
        }

        public ApiTypeAttribute(string name)
            : base(ApiProviderKind.DataType)
        {
            Name = name;
        }

        public ApiTypeAttribute(string name, bool global)
            : base(ApiProviderKind.DataType, global)
        {
            Name = name;
        }
    }
}