//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;

    public class PartServiceAttribute : ApiHostAttribute
    {
        public PartServiceAttribute(string name)
            : base(name)
        {

        }

        public PartServiceAttribute()
        {

        }
    }
}