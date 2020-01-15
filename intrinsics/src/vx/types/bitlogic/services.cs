//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class VXTypes
    {
        [PrimalClosures(PrimalKind.Integers)]
        public readonly struct BitLogic128<T> : IBitLogic<Vector128<T>>
            where T : unmanaged
        {
            public static BitLogic128<T> Svc => default;
            
            [MethodImpl(Inline)]
            public Vector128<T> and(Vector128<T> a, Vector128<T> b)
                => ginx.vand(a,b);

            [MethodImpl(Inline)]
            public Vector128<T> or(Vector128<T> a, Vector128<T> b)
                => ginx.vor(a,b);

            [MethodImpl(Inline)]
            public Vector128<T> xor(Vector128<T> a, Vector128<T> b)
                => ginx.vxor(a,b);

            [MethodImpl(Inline)]
            public Vector128<T> cimpl(Vector128<T> a, Vector128<T> b)
                => ginx.vcimpl(a,b);

            [MethodImpl(Inline)]
            public Vector128<T> cnonimpl(Vector128<T> a, Vector128<T> b)
                => ginx.vcnonimpl(a,b);

            [MethodImpl(Inline)]
            public Vector128<T> @false()
                => default;

            [MethodImpl(Inline)]
            public Vector128<T> identity(Vector128<T> a)
                => a;

            [MethodImpl(Inline)]
            public Vector128<T> impl(Vector128<T> a, Vector128<T> b)
                => ginx.vimpl(a,b);

            [MethodImpl(Inline)]
            public Vector128<T> nand(Vector128<T> a, Vector128<T> b)
                => ginx.vnand(a,b);

            [MethodImpl(Inline)]
            public Vector128<T> nonimpl(Vector128<T> a, Vector128<T> b)
                => ginx.vnonimpl(a,b);

            [MethodImpl(Inline)]
            public Vector128<T> nor(Vector128<T> a, Vector128<T> b)
                => ginx.vnor(a,b);

            [MethodImpl(Inline)]
            public Vector128<T> not(Vector128<T> a)
                => ginx.vnot(a);

            [MethodImpl(Inline)]
            public Vector128<T> select(Vector128<T> a, Vector128<T> b, Vector128<T> c)
                => ginx.vselect(a,b,c);

            [MethodImpl(Inline)]
            public Vector128<T> @true()
                => VPattern.vones<T>(n128);

            [MethodImpl(Inline)]
            public Vector128<T> xnor(Vector128<T> a, Vector128<T> b)
                => ginx.vxnor(a,b);
        }

        [PrimalClosures(PrimalKind.Integers)]
        public readonly struct BitLogic256<T> : IBitLogic<Vector256<T>>
            where T : unmanaged
        {
            public static BitLogic256<T> Svc => default;
            
            [MethodImpl(Inline)]
            public Vector256<T> and(Vector256<T> a, Vector256<T> b)
                => ginx.vand(a,b);

            [MethodImpl(Inline)]
            public Vector256<T> or(Vector256<T> a, Vector256<T> b)
                => ginx.vor(a,b);

            [MethodImpl(Inline)]
            public Vector256<T> xor(Vector256<T> a, Vector256<T> b)
                => ginx.vxor(a,b);

            [MethodImpl(Inline)]
            public Vector256<T> cimpl(Vector256<T> a, Vector256<T> b)
                => ginx.vcimpl(a,b);

            [MethodImpl(Inline)]
            public Vector256<T> cnonimpl(Vector256<T> a, Vector256<T> b)
                => ginx.vcnonimpl(a,b);

            [MethodImpl(Inline)]
            public Vector256<T> @false()
                => default;

            [MethodImpl(Inline)]
            public Vector256<T> identity(Vector256<T> a)
                => a;

            [MethodImpl(Inline)]
            public Vector256<T> impl(Vector256<T> a, Vector256<T> b)
                => ginx.vimpl(a,b);

            [MethodImpl(Inline)]
            public Vector256<T> nand(Vector256<T> a, Vector256<T> b)
                => ginx.vnand(a,b);

            [MethodImpl(Inline)]
            public Vector256<T> nonimpl(Vector256<T> a, Vector256<T> b)
                => ginx.vnonimpl(a,b);

            [MethodImpl(Inline)]
            public Vector256<T> nor(Vector256<T> a, Vector256<T> b)
                => ginx.vnor(a,b);

            [MethodImpl(Inline)]
            public Vector256<T> not(Vector256<T> a)
                => ginx.vnot(a);

            [MethodImpl(Inline)]
            public Vector256<T> select(Vector256<T> a, Vector256<T> b, Vector256<T> c)
                => ginx.vselect(a,b,c);

            [MethodImpl(Inline)]
            public Vector256<T> @true()
                => VPattern.vones<T>(n256);

            [MethodImpl(Inline)]
            public Vector256<T> xnor(Vector256<T> a, Vector256<T> b)
                => ginx.vxnor(a,b);
        }         
    }
}