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
            this.Id = Moniker.Provider.Define(method);
        }

        public virtual Moniker Id {get;}
            

        public abstract bool IsGeneric {get;}
        
        public override string ToString()
            => Id;

        public bool RequiresImmediate
            => Method.RequiresImmediate();
    }
}