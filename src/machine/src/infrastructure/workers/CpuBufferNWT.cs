//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    
    public readonly struct CpuBuffer<N,W,T>        
        where N : unmanaged, ITypeNat
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {
        readonly T[] Data;

        [MethodImpl(Inline)]
        internal CpuBuffer(T[] data)
        {
            Data = data;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => (int)value<N>();
        }

        public Span<T> Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }        

        [MethodImpl(Inline)]
        public void Clear(W16 w)
        {
            first(Content.Cast<T,ushort>()) = Zero16u;
        }

        [MethodImpl(Inline)]
        public void Clear(W32 w)
        {
            first(Content.Cast<T,uint>()) = Zero32u;
        }

        [MethodImpl(Inline)]
        public void Clear(W64 w)
        {
            first(Content.Cast<T,ulong>()) = Zero64u;
        }

        [MethodImpl(Inline)]
        public void Clear(W128 w)
        {
            first(Content.Cast<T,Fixed128>()) = Fixed128.Empty;
        }
    }
}