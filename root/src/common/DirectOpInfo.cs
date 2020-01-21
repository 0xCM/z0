//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    public class DirectOpInfo : OpInfo
    {
        public DirectOpInfo(Moniker id, string name, MethodInfo method)
            : base(id, name,method)
        {

        }
    }
}