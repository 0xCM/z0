//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a bit-level isomorphism relationship between two types
    /// </summary>
    [Free]
    public interface IIsomorhphic
    {
        Type SourceType {get;}

        Type TargetType {get;}
    }

    /// <summary>
    /// Characterizes a bit-level isomorphism relationship between two types
    /// </summary>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    [Free]
    public interface IIsomorhphic<S,T> : IIsomorhphic
    {
        Type IIsomorhphic.SourceType => typeof(S);

        Type IIsomorhphic.TargetType => typeof(T);
    }

    [Free]
    public interface IIsomorphic<H,S,T> : IIsomorhphic<S,T>
        where H : unmanaged, IIsomorphic<H,S,T>
    {


    }
}