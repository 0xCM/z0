//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static Konst;
    using static Memories;
    using static AsIn;

    using BL = ByteLogic;

    partial class LogicSquares
    {
        public readonly struct Not<W,T> : IUnarySquare<W,T>
            where W : unmanaged, ITypeWidth
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public void Invoke(in T src, ref T dst)
            {
                if(typeof(W) == typeof(W64))
                    BL.not(in uint8(in src), ref As.uint8(ref dst));
                else if(typeof(W) == typeof(W128))
                    LogicSquare.not(w128, src, ref dst);   
                else if(typeof(W) == typeof(W256))
                    LogicSquare.not(w256, src, ref dst);   
                else
                    throw Unsupported.define<W>();
            }

            [MethodImpl(Inline)]
            public void Invoke(int count, int step, in T src, ref T dst)
            {
                if(typeof(W) == typeof(W128))
                    LogicSquare.not(w128, count, step, src, ref dst);
                else if(typeof(W) == typeof(W256))
                    LogicSquare.not(w256, count, step, src, ref dst);
                else
                    throw Unsupported.define<W>();
            }
        }
    }
}