//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    public class GenericOpSpec : RootedOpSpec
    {            
        public static GenericOpSpec Define(OpIdentity id, MethodInfo method, NumericKind[] kinds)            
            => new GenericOpSpec(ApiHost.Empty, id,method, kinds);

        public static GenericOpSpec Define(ApiHost host, OpIdentity id, MethodInfo method, NumericKind[] kinds)            
            => new GenericOpSpec(host, id,method, kinds);

        GenericOpSpec(ApiHost host, OpIdentity id, MethodInfo method, NumericKind[] kinds)
            : base(id, method)
        {
            this.Kinds = kinds;
            this.Host = host;
        }

        public ApiHost Host;
    
        public NumericKind[] Kinds {get;}       
    }
}