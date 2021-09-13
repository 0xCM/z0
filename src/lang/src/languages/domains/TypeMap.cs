//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    using lang;

    public abstract class TypeMap<S,T>
        where S : ILang, ITypeDomain<S>, new()
        where T : ILang, ITypeDomain<T>, new()
    {
        Index<S> Source {get;}

        Index<T> Target {get;}
    }
}