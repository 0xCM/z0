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
        public static DirectOpSpec Define(ApiHost host, OpIdentity id, MethodInfo method)            
            => new DirectOpSpec(host, id,method);

        public static DirectOpSpec Define(OpIdentity id, MethodInfo method)            
            => new DirectOpSpec(ApiHost.Empty, id,method);

        DirectOpSpec(ApiHost host, OpIdentity id, MethodInfo method)
            : base(id, method)
        {
            Host = host;
        }

        public ApiHost Host;

    }
}