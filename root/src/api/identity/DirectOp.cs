//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Identify;

    public readonly struct DirectOp 
    {        
        public ApiHost Host {get;}

        public OpIdentity Id {get;}            

        public MethodInfo ConcreteMethod {get;}        

        [MethodImpl(Inline)]
        public static DirectOp Define(ApiHost host, OpIdentity id, MethodInfo method)            
            => new DirectOp(host, id,method);

        [MethodImpl(Inline)]
        DirectOp(ApiHost host, OpIdentity id, MethodInfo method)
        {
            Host = host;
            Id = id;
            ConcreteMethod = method;
        }

        public override string ToString()
            => Id;
    }
}