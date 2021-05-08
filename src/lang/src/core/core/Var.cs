//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Var : IDeclaration<Var>
    {
        public IScope Scope {get;}

        public Identifier Name {get;}

        public DataType Type {get;}

        [MethodImpl(Inline)]
        public Var(IScope scope, Identifier name, DataType type)
        {
            Scope = scope;
            Type = type;
            Name = name;
        }
    }
}