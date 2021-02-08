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
        public Identifier Name {get;}

        public DataType Type {get;}

        [MethodImpl(Inline)]
        public Var(Identifier name, DataType type)
        {
            Type = type;
            Name = name;
        }

        [MethodImpl(Inline)]
        public static implicit operator Var((string name, DataType type) src)
            => new Var(src.name, src.type);
    }
}