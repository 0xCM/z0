//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IReflexArtifact
    {

    }

    public interface IReflexArtifact<T> : IReflexArtifact
    {
        T Definition {get;}
    }
}