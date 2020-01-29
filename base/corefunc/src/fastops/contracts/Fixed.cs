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
    using System.Security;

    using static zfunc;

    public interface IFixed
    {
        int Width {get;}
    }

    public interface IFixed<W> : IFixed
        where W : unmanaged, ITypeNat
    {
        W NatWidth => default;
    }

    public interface IFixed<F,W> : IFixed<W>
        where F : unmanaged, IFixed<F,W>
        where W : unmanaged, ITypeNat
    {
        
    }
}