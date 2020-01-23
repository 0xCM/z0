//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public class OpClosureSpec 
    {
        public static OpClosureSpec Define(Moniker id, PrimalKind kind, MethodInfo method)
            => new OpClosureSpec(id,kind,method);

        OpClosureSpec(Moniker id, PrimalKind kind, MethodInfo method)
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