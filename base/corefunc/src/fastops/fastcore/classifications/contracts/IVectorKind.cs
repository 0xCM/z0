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

    public interface IVectorKind : IKind<VectorKind>
    {

    }

    public interface IVectorKind<W,T> : IVectorKind
        where W : unmanaged, ITypeNat
        where T : unmanaged
    {

    }
}