//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static Seed;
    using static Memories;

    partial class LogicSquares
    {
        public readonly struct Not<W,T> : IUnarySquare<W,T>
            where W : unmanaged, ITypeWidth
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public void Invoke(in T src, ref T dst)
            {
                if(typeof(W) == typeof(W128))
                    LSquare.not(w128, src, ref dst);   
                else if(typeof(W) == typeof(W256))
                    LSquare.not(w256, src, ref dst);   
                else
                    throw Unsupported.define<W>();
            }

            [MethodImpl(Inline)]
            public void Invoke(int count, int step, in T src, ref T dst)
            {
                if(typeof(W) == typeof(W128))
                    LSquare.not(w128, count, step, src, ref dst);
                else if(typeof(W) == typeof(W256))
                    LSquare.not(w256, count, step, src, ref dst);
                else
                    throw Unsupported.define<W>();
            }
        }

        [Closures(UnsignedInts), Not]
        public readonly struct Not128<T> : IUnarySquare<W128,T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public void Invoke(in T src, ref T dst)
                => LSquare.not(w128, src, ref dst);   

            [MethodImpl(Inline)]
            public void Invoke(int count, int step, in T src, ref T dst)
                => LSquare.not(w128, count, step, src, ref dst);   
        }


        [Closures(UnsignedInts), Not]
        public readonly struct Not256<T> : IUnarySquare<W256,T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public void Invoke(in T src, ref T dst)
                => LSquare.not(w256, src, ref dst);   

            [MethodImpl(Inline)]
            public void Invoke(int count, int step, in T src, ref T dst)
                => LSquare.not(w256, count, step, src, ref dst);   

        }

    }
}