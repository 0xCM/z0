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

    public interface IKind<K>
        where K : unmanaged, Enum
    {
        K Classifier {get;}
    }

    public interface IVectorKind : IKind<VectorKind>
    {

    }

    public interface IBlockKind : IKind<BlockKind>
    {


    }

    public interface IPrimalKind : IKind<PrimalKind>
    {

    }

}