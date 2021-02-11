//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;


    [Free]
    public interface IEnvVar : IVar
    {

    }

    [Free]
    public interface IEnvVar<T> : IEnvVar, IVar<T>
        where T : struct
    {

    }
}