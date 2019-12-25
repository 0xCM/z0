//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;    

    public static class GDel
    {        
        [MethodImpl(Inline)]
        public static BinaryOp<T> add<T>()
            where T : unmanaged
                => gmath.add<T>;

        [MethodImpl(Inline)]
        public static BinaryOp<T> sub<T>()
            where T : unmanaged
                => gmath.sub<T>;

        [MethodImpl(Inline)]
        public static BinaryOp<T> mul<T>()
            where T : unmanaged
                => gmath.mul<T>;

        [MethodImpl(Inline)]
        public static BinaryOp<T> div<T>()
            where T : unmanaged
                => gmath.div<T>;

        [MethodImpl(Inline)]
        public static BinaryOp<T> mod<T>()
            where T : unmanaged
                => gmath.mod<T>;

        [MethodImpl(Inline)]
        public static UnaryOp<T> negate<T>()
            where T : unmanaged
                => gmath.negate<T>;

        [MethodImpl(Inline)]
        public static UnaryOp<T> inc<T>()
            where T : unmanaged
                => gmath.inc<T>;

        [MethodImpl(Inline)]
        public static UnaryOp<T> dec<T>()
            where T : unmanaged
                => gmath.dec<T>;

        [MethodImpl(Inline)]
        public static BinaryPred<T> eq<T>()
            where T : unmanaged
                => gmath.eq<T>;

        [MethodImpl(Inline)]
        public static BinaryPred<T> gt<T>()
            where T : unmanaged
                => gmath.gt<T>;

        [MethodImpl(Inline)]
        public static BinaryPred<T> gteq<T>()
            where T : unmanaged
                => gmath.gteq<T>;

        [MethodImpl(Inline)]
        public static BinaryPred<T> lt<T>()
            where T : unmanaged
                => gmath.lt<T>;

        [MethodImpl(Inline)]
        public static BinaryPred<T> lteq<T>()
            where T : unmanaged
                => gmath.lteq<T>;
                                
       [MethodImpl(Inline)]
        public static BinaryOp<T> and<T>()
            where T : unmanaged
                => gmath.and<T>;

 
        [MethodImpl(Inline)]
        public static BinaryOp<T> xor<T>()
            where T : unmanaged
                => gmath.xor<T>;

        [MethodImpl(Inline)]
        public static UnaryOp<T> not<T>()
            where T : unmanaged
                => gmath.not<T>;

   }

}