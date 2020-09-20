//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Attaches an arbitrary number of urls to the target
    /// </summary>
    public class UrlAttribute : Attribute
    {
        public UrlAttribute(params string[] src)
        {
            Attached = src;
        }

        public string[] Attached {get;}
    }
}