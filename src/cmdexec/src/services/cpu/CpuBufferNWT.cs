//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    public ref struct CpuBuffer<N,W,T>
        where N : unmanaged, ITypeNat
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {
        readonly Span<T> Data;

        [MethodImpl(Inline)]
        public CpuBuffer(T[] data)
            => Data = data;

        public int Length
        {
            [MethodImpl(Inline)]
            get => (int)nat64u<N>();
        }

        public Span<T> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        public void Clear(W16 w)
        {
            first(Data.Recover<T,ushort>()) = Zero16u;
        }

        [MethodImpl(Inline)]
        public void Clear(W32 w)
        {
            first(Data.Recover<T,uint>()) = Zero32u;
        }

        [MethodImpl(Inline)]
        public void Clear(W64 w)
        {
            first(Data.Recover<T,ulong>()) = Zero64u;
        }

        [MethodImpl(Inline)]
        public void Clear(W128 w)
        {
            first(Data.Recover<T,Cell128>()) = Cell128.Empty;
        }
    }
}