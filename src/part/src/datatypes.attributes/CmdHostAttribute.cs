//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Identifies a command host
    /// </summary>
    public class CmdRouterAttribute : PartServiceAttribute
    {
        public CmdRouterAttribute(string name)
            : base(name)
        {

        }

        public CmdRouterAttribute()
        {

        }
    }
}