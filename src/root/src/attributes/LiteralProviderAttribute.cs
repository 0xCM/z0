//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Applied to a structural artifact or member field, method or property to indicate that the target provides some sort of literal data
    /// </summary>
    public class LiteralProviderAttribute : Attribute
    {
        public LiteralProviderAttribute()
        {

        }

        public LiteralUsage Usage {get;}
    }
}