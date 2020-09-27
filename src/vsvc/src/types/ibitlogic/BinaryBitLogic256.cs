//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    using K = BitLogicKinds;

    partial class VServices
    {
        [Closures(Integers)]
        public readonly struct BinaryBitLogic256<T> : IBinaryBitLogic<Vector256<T>>, ITernaryBitLogic<Vector256<T>>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector256<T> and(Vector256<T> a, Vector256<T> b)
                => gvec.vand(a,b);

            [MethodImpl(Inline)]
            public Vector256<T> or(Vector256<T> a, Vector256<T> b)
                => gvec.vor(a,b);

            [MethodImpl(Inline)]
            public Vector256<T> xor(Vector256<T> a, Vector256<T> b)
                => gvec.vxor(a,b);

            [MethodImpl(Inline)]
            public Vector256<T> cimpl(Vector256<T> a, Vector256<T> b)
                => gvec.vcimpl(a,b);

            [MethodImpl(Inline)]
            public Vector256<T> cnonimpl(Vector256<T> a, Vector256<T> b)
                => gvec.vcnonimpl(a,b);

            [MethodImpl(Inline)]
            public Vector256<T> @false()
                => default;

            [MethodImpl(Inline)]
            public Vector256<T> identity(Vector256<T> a)
                => a;

            [MethodImpl(Inline)]
            public Vector256<T> impl(Vector256<T> a, Vector256<T> b)
                => gvec.vimpl(a,b);

            [MethodImpl(Inline)]
            public Vector256<T> nand(Vector256<T> a, Vector256<T> b)
                => gvec.vnand(a,b);

            [MethodImpl(Inline)]
            public Vector256<T> nonimpl(Vector256<T> a, Vector256<T> b)
                => gvec.vnonimpl(a,b);

            [MethodImpl(Inline)]
            public Vector256<T> nor(Vector256<T> a, Vector256<T> b)
                => gvec.vnor(a,b);

            [MethodImpl(Inline)]
            public Vector256<T> not(Vector256<T> a)
                => gvec.vnot(a);

            [MethodImpl(Inline)]
            public Vector256<T> select(Vector256<T> a, Vector256<T> b, Vector256<T> c)
                => gvec.vselect(a,b,c);

            [MethodImpl(Inline)]
            public Vector256<T> @true()
                => gvec.vones<T>(n256);

            [MethodImpl(Inline)]
            public Vector256<T> xnor(Vector256<T> a, Vector256<T> b)
                => gvec.vxnor(a,b);

            [MethodImpl(Inline)]
            public Vector256<T> eval<K>(Vector256<T> a, K kind = default)
                where K : unmanaged, IBitLogicKind
                    => eval_unary_1(a,kind);

            [MethodImpl(Inline)]
            public Vector256<T> eval<K>(Vector256<T> a, Vector256<T> b, K kind = default)
                where K : unmanaged, IBitLogicKind
                    => eval_binary_1(a,b,kind);

            [MethodImpl(Inline)]
            public Vector256<T> eval<K>(Vector256<T> a, Vector256<T> b, Vector256<T> c, K kind = default)
                where K : unmanaged, IBitLogicKind
                    => eval_ternary_1(a, b, c,kind);

            [MethodImpl(Inline)]
            Vector256<T> eval_unary_1<B>(Vector256<T> a, B kind)
                where B : unmanaged, IBitLogicKind
            {
                if(typeof(B) == typeof(K.Not))
                    return not(a);
                else
                    throw no<T>();
            }

            [MethodImpl(Inline)]
            Vector256<T> eval_binary_1<B>(Vector256<T> a, Vector256<T> b, B kind)
                where B : unmanaged, IBitLogicKind
            {
                if(typeof(B) == typeof(K.And))
                    return and(a,b);
                else if(typeof(B) == typeof(K.Or))
                    return or(a,b);
                else if(typeof(B) == typeof(K.Xor))
                    return xor(a,b);
                else if(typeof(B) == typeof(K.Nand))
                    return nand(a,b);
                else if(typeof(B) == typeof(K.Nor))
                    return nor(a,b);
                else if(typeof(B) == typeof(K.Xnor))
                    return xnor(a,b);
                else
                    return eval_binary_2(a,b,kind);
            }

            [MethodImpl(Inline)]
            Vector256<T> eval_binary_2<B>(Vector256<T> a, Vector256<T> b, B kind)
                where B : unmanaged, IBitLogicKind
            {
                if(typeof(B) == typeof(K.Impl))
                    return impl(a,b);
                else if(typeof(B) == typeof(K.NonImpl))
                    return nonimpl(a,b);
                else if(typeof(B) == typeof(K.CImpl))
                    return cimpl(a,b);
                else if(typeof(B) == typeof(K.CNonImpl))
                    return cnonimpl(a,b);
                else
                    throw no<T>();
            }

            [MethodImpl(Inline)]
            Vector256<T> eval_ternary_1<B>(Vector256<T> a, Vector256<T> b, Vector256<T> c, B kind)
                where B : unmanaged, IBitLogicKind
            {
                if(typeof(B) == typeof(K.Select))
                    return select(a,b,c);
                else
                    throw no<T>();
            }
        }
    }
}