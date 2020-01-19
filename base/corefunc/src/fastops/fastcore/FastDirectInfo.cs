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

    public class FastDirectInfo : FastOpInfo
    {
        public FastDirectInfo(string name, MethodInfo method)
            : base(name,method)
        {

        }

        public override bool IsGeneric => false;
    }
}