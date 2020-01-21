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
    /// Characterizes a higher-kind
    /// </summary>
    public interface ITypeKind : IKind<TypeKind>
    {        

    }

    public interface ITypeKind<K> : ITypeKind
        where K : ITypeKind<K>
    {

    }

    public interface ITypeKind<K,T> : ITypeKind<K>
        where T : unmanaged
        where K : ITypeKind<K,T>
    {

    }

    public interface ITypeKind<K,N,T> : ITypeKind<K,T>
        where T : unmanaged
        where K : ITypeKind<K,N,T>
        where N : unmanaged, ITypeNat
    {

    }

    public interface ITypeKind<K,M,N,T> : ITypeKind<K,T>
        where K : ITypeKind<K,M,N,T>
        where T : unmanaged
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
    {

    }

}