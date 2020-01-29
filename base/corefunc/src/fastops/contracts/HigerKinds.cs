//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public interface IHigherKind
    {
        
    }

    /// <summary>
    /// Characterizes a higher-kinded type
    /// </summary>
    public interface IHKType : IKind<HKTypeKind>, IHigherKind
    {        

    }

    /// <summary>
    /// Characterizes a higher-kinded function
    /// </summary>
    public interface IHKFunc : IKind<HKFunctionKind>, IHigherKind
    {

    }

    public interface IHKType<K> : IHKType
        where K : IHKType<K>
    {

    }

    public interface IHKType<K,T> : IHKType<K>
        where T : unmanaged
        where K : IHKType<K,T>
    {

    }

    public interface IHKType<K,N,T> : IHKType<K,T>
        where T : unmanaged
        where K : IHKType<K,N,T>
        where N : unmanaged, ITypeNat
    {

    }

    public interface IHKType<K,M,N,T> : IHKType<K,T>
        where K : IHKType<K,M,N,T>
        where T : unmanaged
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
    {

    }


    public interface IHKFunc<K> : IHKFunc
        where K : IHKFunc<K>
    {

    }

}