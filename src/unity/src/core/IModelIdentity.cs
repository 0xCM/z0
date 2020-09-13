//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IModelIdentity
    {
        BinaryCode Identifier {get;}
    }

    public interface IModelIdentity<T> : IModelIdentity
        where T : IModelIdentity<T>
    {
    }
}