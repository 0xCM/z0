//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public abstract class OpInfo
    {
        public Moniker Id {get;}            

        public string Name {get;}

        public MethodInfo Method {get;}

        protected OpInfo(Moniker id, string name, MethodInfo method)
        {
            this.Id = id;
            this.Name = name;
            this.Method = method;
        }
        
        public override string ToString()
            => Id;
    }
}