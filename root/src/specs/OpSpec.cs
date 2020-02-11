//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;


    public interface IOpSpec
    {
        OpIdentity Id {get;}            
    }

    public interface IRootedOpSpec : IOpSpec
    {
        MethodInfo Root {get;}        
    }


    public abstract class OpSpec : IOpSpec
    {        
        public OpIdentity Id {get;}            

        protected OpSpec(OpIdentity id)
        {
            this.Id = id;
        }
        
        public override string ToString()
            => Id;
    }


    public abstract class RootedOpSpec : OpSpec, IRootedOpSpec
    {
        protected RootedOpSpec(OpIdentity id, MethodInfo method)
            : base(id)
        {
            this.Root = method;
        }

        public MethodInfo Root {get;}

    }
}