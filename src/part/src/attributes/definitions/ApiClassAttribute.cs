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
    public class ApiClassAttribute : Attribute
    {
        public ApiClassKind Kind {get;}

        public ApiClassAttribute(ApiClassKind kind)
        {
            Kind = kind;
        }
    }
}