//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public class OpClosure 
    {
        public OpClosure(Moniker id, PrimalKind kind, MethodInfo method)
        {
            this.Id = id;
            this.Kind = kind;
            this.ClosedMethod = method;
        }
    
        public Moniker Id {get;}

        public PrimalKind Kind {get;}

        public MethodInfo ClosedMethod {get;}

        public void Deconstruct(out Moniker id, out PrimalKind k, out MethodInfo closed)
        {
            id = Id;
            k = Kind;
            closed = ClosedMethod;
        }
    }
}