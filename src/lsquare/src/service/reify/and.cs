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
        public readonly struct And<W,T> : IBinarySquare<W,T>
            where W : unmanaged, ITypeWidth
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public void Invoke(in T a, in T b, ref T dst)
            {
                if(typeof(W) == typeof(W64))
                    BL.and(in uint8(in a), in uint8(in b), ref As.uint8(ref dst));
                else if(typeof(W) == typeof(W128))
                    LogicSquare.and(w128, a, b, ref dst);
                else if(typeof(W) == typeof(W256))
                    LogicSquare.and(w256, a, b, ref dst);
                else
                    throw Unsupported.define<W>();
            }

            [MethodImpl(Inline)]
            public void Invoke(int count, int step, in T a, in T b, ref T dst)
            {
                if(typeof(W) == typeof(W128))
                    LogicSquare.and(w128, count, step, a, b, ref dst);   
                else if(typeof(W) == typeof(W256))
                    LogicSquare.and(w256, count, step, a, b, ref dst);   
                else
                    throw Unsupported.define<W>();
            }
        }
   }
}