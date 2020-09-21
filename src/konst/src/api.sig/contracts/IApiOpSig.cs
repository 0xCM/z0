//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static z;
    using static Konst;

    public interface IApiOpSig : IApiSig
    {
        /// <summary>
        /// The declaring api host
        /// </summary>
        ArtifactIdentifier Host {get;}
    }

    public interface IApiOpSig<S> : IApiOpSig
        where S : struct, IApiOpSig<S>
    {

    }

    public interface IApiOpSig<S,T0> : IApiOpSig
        where S : struct, IApiOpSig<S,T0>
        where T0: IApiTypeSig
    {

    }

    public interface IApiOpSig<S,T0,T1> : IApiOpSig
        where S : struct, IApiOpSig<S,T0,T1>
        where T0: IApiTypeSig
        where T1: IApiTypeSig
    {

    }

    public interface IApiOpSig<S,T0,T1,T2> : IApiOpSig
        where S : struct, IApiOpSig<S,T0,T1,T2>
        where T0: IApiTypeSig
        where T1: IApiTypeSig
        where T2: IApiTypeSig
    {

    }

    public interface IApiOpSig<S,T0,T1,T2,T3> : IApiOpSig
        where T1: IApiTypeSig
        where T0: IApiTypeSig
        where T2: IApiTypeSig
        where T3: IApiTypeSig
    {

    }

}