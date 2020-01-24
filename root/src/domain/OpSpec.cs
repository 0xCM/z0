//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public abstract class OpSpec
    {        
        public Moniker Id {get;}            

        public string Name {get;}

        public MethodInfo Method {get;}

        protected OpSpec(Moniker id, string name, MethodInfo method)
        {
            this.Id = id;
            this.Name = name;
            this.Method = method;
        }
        
        public override string ToString()
            => Id;
    }
}