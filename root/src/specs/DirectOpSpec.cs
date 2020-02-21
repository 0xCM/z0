//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct DirectOpSpec : IDirectOpSpec
    {        
        public ApiHost Host {get;}

        public OpIdentity Id {get;}            

        public MethodInfo ConcreteMethod {get;}        

        [MethodImpl(Inline)]
        public static DirectOpSpec Define(ApiHost host, OpIdentity id, MethodInfo method)            
            => new DirectOpSpec(host, id,method);

        [MethodImpl(Inline)]
        DirectOpSpec(ApiHost host, OpIdentity id, MethodInfo method)
        {
            Host = host;
            Id = id;
            ConcreteMethod = method;
        }

        public override string ToString()
            => Id;
    }
}