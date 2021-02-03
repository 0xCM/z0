//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Var : IDeclaration<Var>
    {
        public DataType Type {get;}

        public Identifier Name {get;}

        [MethodImpl(Inline)]
        public Var(DataType type, Identifier name)
        {
            Type = type;
            Name = name;
        }
    }
}