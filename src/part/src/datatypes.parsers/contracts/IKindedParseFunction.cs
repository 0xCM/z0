//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IKindedParseFunction : IParseFunction
    {

        dynamic Kind {get;}

    }

    public interface IParseFunction<T,K> : IKindedParseFunction, IParseFunction<T>
        where K : unmanaged
    {
        dynamic IKindedParseFunction.Kind
            => Kind;

        new K Kind {get;}
    }
}