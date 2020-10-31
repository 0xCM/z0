//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IApiSig
    {

    }

    [Free]
    public interface IApiTypeSig : IApiSig
    {

    }

    [Free]
    public interface IApiOpSig : IApiSig
    {
        /// <summary>
        /// The declaring api host
        /// </summary>
        ClrArtifactKey Host {get;}
    }

    [Free]
    public interface IApiOpSig<S> : IApiOpSig
        where S : struct, IApiOpSig<S>
    {

    }

    [Free]
    public interface IApiOpSig<S,T0> : IApiOpSig
        where S : struct, IApiOpSig<S,T0>
        where T0: IApiTypeSig
    {

    }

    [Free]
    public interface IApiOpSig<S,T0,T1> : IApiOpSig
        where S : struct, IApiOpSig<S,T0,T1>
        where T0: IApiTypeSig
        where T1: IApiTypeSig
    {

    }

    [Free]
    public interface IApiOpSig<S,T0,T1,T2> : IApiOpSig
        where S : struct, IApiOpSig<S,T0,T1,T2>
        where T0: IApiTypeSig
        where T1: IApiTypeSig
        where T2: IApiTypeSig
    {

    }

    [Free]
    public interface IApiOpSig<S,T0,T1,T2,T3> : IApiOpSig
        where T1: IApiTypeSig
        where T0: IApiTypeSig
        where T2: IApiTypeSig
        where T3: IApiTypeSig
    {

    }
}