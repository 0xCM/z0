//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IClosedBlockType : IKind<ClosedBlockKind>, ITypeKind
    {


    }

    public interface IBlockedType<W,T> : IClosedBlockType, IFixedWidth<W>
        where W : unmanaged, ITypeNat
        where T : unmanaged
    {

    }
}