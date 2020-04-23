//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Identifies a type that defines an interface-contracted api surface
    /// </summary>
    public class ApiServiceFactoryAttribute : Attribute
    {
        public ApiServiceFactoryAttribute()
        {
            this.ServiceCollectionName = string.Empty;
        }

        public ApiServiceFactoryAttribute(string name)
        {
            this.ServiceCollectionName = name;
        }

        /// <summary>
        /// The service collection identifier
        /// </summary>
        public string ServiceCollectionName {get;}
    }

}