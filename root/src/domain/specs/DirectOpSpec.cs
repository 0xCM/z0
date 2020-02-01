//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public sealed class DirectOpSpec : RootedOpSpec
    {        
        public static DirectOpSpec Define(Moniker id, MethodInfo method)            
            => new DirectOpSpec(id,method);

        DirectOpSpec(Moniker id, MethodInfo method)
            : base(id, method)
        {

        }
    }
}