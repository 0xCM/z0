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

    public class GenericOpSpec : IGenericOpSpec
    {            
        public ApiHost Host {get;}
    
        public OpIdentity Id {get;}            

        public NumericKind[] Kinds {get;}

        public MethodInfo MethodDefinition {get;}

        [MethodImpl(Inline)]
        public static GenericOpSpec Define(ApiHost host, OpIdentity id, MethodInfo method, NumericKind[] kinds)            
            => new GenericOpSpec(host, id,method, kinds);

        [MethodImpl(Inline)]
        GenericOpSpec(ApiHost host, OpIdentity id, MethodInfo method, NumericKind[] kinds)
        {
            this.Kinds = kinds;
            this.Host = host;
            this.Id = id;
            this.MethodDefinition = method;
        }
    }
}