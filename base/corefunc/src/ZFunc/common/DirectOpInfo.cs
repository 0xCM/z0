//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;


    public abstract class FastOpInfo
    {
        public string Name {get;}

        public MethodInfo Method {get;}

        public FastOpInfo(string name, MethodInfo method)
        {
            this.Name = name;
            this.Method = method;
        }

        public virtual Moniker Id 
            => Method.DeriveMoniker();

        public abstract bool IsGeneric {get;}
        public override string ToString()
            => Id;

    }

    public class DirectOpInfo : FastOpInfo
    {
        public static DirectOpInfo Define(string name, MethodInfo method)
            => new DirectOpInfo(name,method);        
        

        public DirectOpInfo(string name, MethodInfo method)
            : base(name,method)
        {

        }

        public override bool IsGeneric => false;
    }
}