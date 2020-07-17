//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    public interface IReflected
    {
        ArtifactIdentity Id {get;}
    }

    public interface IReflected<F> : IReflected
        where  F : struct, IReflected<F>
    {


    }

    public interface IReflected<F,M> : IReflected<F>
        where  F : struct, IReflected<F,M>

    {

    }
}