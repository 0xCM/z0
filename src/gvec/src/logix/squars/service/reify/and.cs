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
    using static In;
    using static SFx;

    using BL = BitLogic.Bytes;
    using LS = LogicSquare;

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
                    BL.and(in uint8(in a), in uint8(in b), ref z.uint8(ref dst));
                else if(typeof(W) == typeof(W128))
                    LS.and(w128, a, b, ref dst);
                else if(typeof(W) == typeof(W256))
                    LS.and(w256, a, b, ref dst);
                else
                    throw no<W>();
            }

            [MethodImpl(Inline)]
            public void Invoke(int count, int step, in T a, in T b, ref T dst)
            {
                if(typeof(W) == typeof(W128))
                    LS.and(w128, count, step, a, b, ref dst);
                else if(typeof(W) == typeof(W256))
                    LS.and(w256, count, step, a, b, ref dst);
                else
                    throw no<W>();
            }
        }
   }
}