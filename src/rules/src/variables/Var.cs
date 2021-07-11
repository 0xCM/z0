//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Rules;

    public readonly struct Var
    {
        public IScope Scope {get;}

        public string Name {get;}

        public DataType Type {get;}

        [MethodImpl(Inline)]
        public Var(IScope scope, string name, DataType type)
        {
            Scope = scope;
            Type = type;
            Name = name;
        }
    }
}