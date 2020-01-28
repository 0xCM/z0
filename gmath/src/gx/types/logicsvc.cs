//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;

    partial class GXTypes
    {
        [PrimalClosures(NumericKind.Integers)]
        public readonly struct BitLogicOps<T> : IBitLogic<T>
            where T : unmanaged
        {
            public static BitLogicOps<T> Ops => default;
            
            [MethodImpl(Inline)]
            public T and(T a, T b)
                => gmath.and(a,b);

            [MethodImpl(Inline)]
            public T or(T a, T b)
                => gmath.or(a,b);

            [MethodImpl(Inline)]
            public T xor(T a, T b)
                => gmath.xor(a,b);

            [MethodImpl(Inline)]
            public T cimpl(T a, T b)
                => gmath.cimpl(a,b);

            [MethodImpl(Inline)]
            public T cnonimpl(T a, T b)
                => gmath.cnonimpl(a,b);

            [MethodImpl(Inline)]
            public T @false()
                => gmath.@false<T>();

            [MethodImpl(Inline)]
            public T identity(T a)
                => gmath.identity(a);

            [MethodImpl(Inline)]
            public T impl(T a, T b)
                => gmath.impl(a,b);

            [MethodImpl(Inline)]
            public T nand(T a, T b)
                => gmath.nand(a,b);

            [MethodImpl(Inline)]
            public T nonimpl(T a, T b)
                => gmath.nonimpl(a,b);

            [MethodImpl(Inline)]
            public T nor(T a, T b)
                => gmath.nor(a,b);

            [MethodImpl(Inline)]
            public T not(T a)
                => gmath.not(a);

            [MethodImpl(Inline)]
            public T select(T a, T b, T c)
                => gmath.select(a,b,c);

            [MethodImpl(Inline)]
            public T @true()
                => gmath.@true<T>();

            [MethodImpl(Inline)]
            public T xnor(T a, T b)
                => gmath.xnor(a,b);
        }
    }

}