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
    using static Memories;

    using K = Kinds;

    partial class VServices
    {
        [NumericClosures(Integers)]
        public readonly struct BitLogic128<T> : IBitLogic<Vector128<T>>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector128<T> and(Vector128<T> a, Vector128<T> b)
                => gvec.vand(a,b);

            [MethodImpl(Inline)]
            public Vector128<T> or(Vector128<T> a, Vector128<T> b)
                => gvec.vor(a,b);

            [MethodImpl(Inline)]
            public Vector128<T> xor(Vector128<T> a, Vector128<T> b)
                => gvec.vxor(a,b);

            [MethodImpl(Inline)]
            public Vector128<T> cimpl(Vector128<T> a, Vector128<T> b)
                => gvec.vcimpl(a,b);

            [MethodImpl(Inline)]
            public Vector128<T> cnonimpl(Vector128<T> a, Vector128<T> b)
                => gvec.vcnonimpl(a,b);

            [MethodImpl(Inline)]
            public Vector128<T> @false()
                => default;

            [MethodImpl(Inline)]
            public Vector128<T> identity(Vector128<T> a)
                => a;

            [MethodImpl(Inline)]
            public Vector128<T> impl(Vector128<T> a, Vector128<T> b)
                => gvec.vimpl(a,b);

            [MethodImpl(Inline)]
            public Vector128<T> nand(Vector128<T> a, Vector128<T> b)
                => gvec.vnand(a,b);

            [MethodImpl(Inline)]
            public Vector128<T> nonimpl(Vector128<T> a, Vector128<T> b)
                => gvec.vnonimpl(a,b);

            [MethodImpl(Inline)]
            public Vector128<T> nor(Vector128<T> a, Vector128<T> b)
                => gvec.vnor(a,b);

            [MethodImpl(Inline)]
            public Vector128<T> not(Vector128<T> a)
                => gvec.vnot(a);

            [MethodImpl(Inline)]
            public Vector128<T> select(Vector128<T> a, Vector128<T> b, Vector128<T> c)
                => gvec.vselect(a,b,c);

            [MethodImpl(Inline)]
            public Vector128<T> @true()
                => gvec.vones<T>(n128);

            [MethodImpl(Inline)]
            public Vector128<T> xnor(Vector128<T> a, Vector128<T> b)
                => gvec.vxnor(a,b);

            [MethodImpl(Inline)]
            public Vector128<T> eval<K>(Vector128<T> a, K kind = default)
                where K : unmanaged, IBitLogicApiKey
                    => eval_unary_1(a,kind);

            [MethodImpl(Inline)]
            public Vector128<T> eval<K>(Vector128<T> a, Vector128<T> b, K kind = default)
                where K : unmanaged, IBitLogicApiKey
                     => eval_binary_1(a,b,kind);

            [MethodImpl(Inline)]
            public Vector128<T> eval<K>(Vector128<T> a, Vector128<T> b, Vector128<T> c, K kind = default)
                where K : unmanaged, IBitLogicApiKey
                    => eval_ternary_1(a, b, c,kind);

            [MethodImpl(Inline)]
            Vector128<T> eval_unary_1<B>(Vector128<T> a, B kind)
                where B : unmanaged, IBitLogicApiKey
            {
                if(typeof(B) == typeof(K.Not))
                    return not(a);
                else
                    throw Unsupported.define<T>();
            }

            [MethodImpl(Inline)]
            Vector128<T> eval_binary_1<B>(Vector128<T> a, Vector128<T> b, B kind)
                where B : unmanaged, IBitLogicApiKey
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
            Vector128<T> eval_binary_2<B>(Vector128<T> a, Vector128<T> b, B kind)
                where B : unmanaged, IBitLogicApiKey
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
                    throw Unsupported.define<T>();
            }

            [MethodImpl(Inline)]
            Vector128<T> eval_ternary_1<B>(Vector128<T> a, Vector128<T> b, Vector128<T> c, B kind)
                where B : unmanaged, IBitLogicApiKey
            {
                if(typeof(B) == typeof(K.Select))
                    return select(a,b,c);
                else
                    throw Unsupported.define<T>();
            }
        }
    }
}