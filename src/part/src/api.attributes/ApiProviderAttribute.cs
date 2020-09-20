//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Applied to an exposed surface to classify its role/purpose
    /// </summary>
    public class ApiProviderAttribute : Attribute
    {
        public ApiProviderKind Kind {get;}

        public ApiProviderAttribute(ApiProviderKind kind)
        {
            Kind = kind;
        }
    }
}