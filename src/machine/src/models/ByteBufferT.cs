//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public readonly struct ByteBuffer<T>
        where T : unmanaged
    {
        readonly T[] Data;

        [MethodImpl(Inline)]
        internal ByteBuffer(T[] data)
        {
            Data = data;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
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