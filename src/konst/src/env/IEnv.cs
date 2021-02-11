//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

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