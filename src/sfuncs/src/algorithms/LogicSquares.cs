//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static SFx;

    using BL = ByteLogic;
    using LS = vlogic;

    [FunctionalService]
    public partial class LogicSquares : ISFxHost<LogicSquares>
    {
        const NumericKind Closure = UnsignedInts;

        public readonly struct And<W,T> : IBinarySquare<W,T>
            where W : unmanaged, ITypeWidth
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public void Invoke(in T a, in T b, ref T dst)
            {
                if(typeof(W) == typeof(W64))
                    BL.and(u8(a), u8(b), ref u8(dst));
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

        public readonly struct Not<W,T> : IUnarySquare<W,T>
            where W : unmanaged, ITypeWidth
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public void Invoke(in T src, ref T dst)
            {
                if(typeof(W) == typeof(W64))
                    BL.not(in u8(src), ref u8(dst));
                else if(typeof(W) == typeof(W128))
                    LS.not(w128, src, ref dst);
                else if(typeof(W) == typeof(W256))
                    LS.not(w256, src, ref dst);
                else
                    throw no<W>();
            }

            [MethodImpl(Inline)]
            public void Invoke(int count, int step, in T src, ref T dst)
            {
                if(typeof(W) == typeof(W128))
                    LS.not(w128, count, step, src, ref dst);
                else if(typeof(W) == typeof(W256))
                    LS.not(w256, count, step, src, ref dst);
                else
                    throw no<W>();
            }
        }

        [MethodImpl(Inline)]
        public static Not<W,T> not<W,T>(W w = default, T t = default)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => sfunc(w, sfunc<Not<W,T>>(), t);

        [MethodImpl(Inline)]
        public static And<W,T> and<W,T>(W w = default, T t = default)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => sfunc(w, sfunc<And<W,T>>(), t);


        [MethodImpl(Inline), And, Closures(Closure)]
        public static void and<T>(in T a, in T b, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                and(w64, default(T)).Invoke(a, b, ref dst);
            else if(typeof(T) == typeof(ushort))
                and(w256, default(T)).Invoke(a, b, ref dst);
            else if(typeof(T) == typeof(uint))
                and(w256, default(T)).Invoke(4, 8, a, b, ref dst);
            else if(typeof(T) == typeof(ulong))
                and(w256, default(T)).Invoke(16, 4, a, b, ref dst);
            else
                throw no<T>();
        }
    }
}