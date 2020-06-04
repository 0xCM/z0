//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    public abstract class AsciCodeApi<N,T>
        where N : unmanaged, ITypeNat
        where T : AsciCodeApi<N,T>, new()
    {

    }
}