//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface ITypeArity<N> : ITypeArity
        where N : unmanaged, ITypeNat
    {
        int ITypeArity.Arity
        {
            [MethodImpl(Inline)]
            get => (int)NatMath2.natval<N>();
        }
    }

    public interface ITypeArity<N,T> : ITypeArity<N>, ITypeKind<N,T>
        where N : unmanaged, ITypeNat
    {

    }

    public interface ITypeWidth<W> : ITypeWidth
        where W : unmanaged, ITypeNat
    {
        FixedWidth ITypeWidth.Width => (FixedWidth)NatMath2.natval<W>();
    }

    public interface ITypeWidth<W,T> : ITypeWidth<W>
        where W : unmanaged, ITypeNat
    {
        

    }
}