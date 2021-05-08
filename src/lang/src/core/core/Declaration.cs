//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface IDeclaration
    {

    }

    public interface IDeclaration<T> : IDeclaration
        where T : struct, IDeclaration<T>
    {

    }
    public readonly struct Declaration<T>
    {
        public Identifier Name {get;}

        public T Type {get;}

        [MethodImpl(Inline)]
        public Declaration(Identifier name, T type)
        {
            Name = name;
            Type = type;
        }
    }
}