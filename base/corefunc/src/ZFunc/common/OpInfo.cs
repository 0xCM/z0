//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public class DirectOpInfo
    {
        public static DirectOpInfo Define(string name, MethodInfo method)
            => new DirectOpInfo(name,method);        
        
        public string Name {get;}

        public MethodInfo Method {get;}

        public DirectOpInfo(string name, MethodInfo method)
        {
            this.Name = name;
            this.Method = method;
        }

        public Moniker Id 
            => Method.DeriveMoniker();

        public override string ToString()
            => Id;
    }
}