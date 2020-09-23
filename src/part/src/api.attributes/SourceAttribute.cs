//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Applied to a target to specify the target definition source
    /// </summary>
    public class OriginAttribute : Attribute
    {
        public OriginAttribute(object src)
        {
            Source = src;
        }

        public object Source {get;}
    }
}