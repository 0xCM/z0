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

    /// <summary>
    /// Characterizes a higher-kinded representation
    /// </summary>
    public interface IHK
    {
        
    }

    /// <summary>
    /// Characterizes a higher-kinded type representation
    /// </summary>
    public interface IHKType : IKind<HKTypeKind>, IHK
    {        

    }

    /// <summary>
    /// Characterizes a higher-kinded function representation
    /// </summary>
    public interface IHKFunc : IKind<HKFunctionKind>, IHK
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

    public interface IHKFunc<K,N> : IHKFunc<K>
        where K : IHKFunc<K,N>
        where N : unmanaged, ITypeNat
    {
        int Arity 
            => (int)default(N).NatValue;
    }
}