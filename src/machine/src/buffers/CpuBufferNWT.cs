//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Typed;
    using static Control;
    
    public readonly struct CpuBuffer<N,W,T>        
        where N : unmanaged, ITypeNat
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static implicit operator CpuBuffer<T>(CpuBuffer<N,W,T> src)
            => new CpuBuffer<N,W,T>(src.Data);

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
            head(Content.As<T,ushort>()) = Zero16u;
        }

        [MethodImpl(Inline)]
        public void Clear(W32 w)
        {
            head(Content.As<T,uint>()) = Zero32u;
        }

        [MethodImpl(Inline)]
        public void Clear(W64 w)
        {
            head(Content.As<T,ulong>()) = Zero64u;
        }

        [MethodImpl(Inline)]
        public void Clear(W128 w)
        {
            head(Content.As<T,Fixed128>()) = Fixed128.Empty;
        }
    }
}