//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IEnv
    {
        Index<IEnvVar> Variables {get;}
    }

    public interface IEnv<E> : IEnv
        where E : IEnvVarProvider
    {
        new E Variables {get;}

        Index<IEnvVar> IEnv.Variables
            => Variables.Provided;
    }

    public interface IEnvVarProvider
    {
        Index<IEnvVar> Provided {get;}
    }
}