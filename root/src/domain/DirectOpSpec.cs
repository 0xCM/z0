//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    public sealed class DirectOpSpec : OpSpec
    {        
        public static DirectOpSpec Define(Moniker id, string name, MethodInfo method)            
            => new DirectOpSpec(id,name,method);

        DirectOpSpec(Moniker id, string name, MethodInfo method)
            : base(id, name,method)
        {

        }
    }

}