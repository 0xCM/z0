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

    public interface IBlockKind : IKind<BlockKind>
    {


    }

    public interface IBlockKind<W,T> : IBlockKind
        where W : unmanaged, ITypeNat
        where T : unmanaged
    {

    }


}