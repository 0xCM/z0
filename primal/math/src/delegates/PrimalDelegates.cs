//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;    

    public static class PrimalDelegates
    {        
        [MethodImpl(Inline)]
        public static BinaryOp<T> add<T>()
            where T : unmanaged
                => Add<T>.Op;

        [MethodImpl(Inline)]
        public static BinaryOp<T> sub<T>()
            where T : unmanaged
                => Sub<T>.Op;

        [MethodImpl(Inline)]
        public static BinaryOp<T> mul<T>()
            where T : unmanaged
                => Mul<T>.Op;

        [MethodImpl(Inline)]
        public static BinaryOp<T> div<T>()
            where T : unmanaged
                => Div<T>.Op;

        [MethodImpl(Inline)]
        public static BinaryOp<T> mod<T>()
            where T : unmanaged
                => Mod<T>.Op;


        [MethodImpl(Inline)]
        public static UnaryOp<T> negate<T>()
            where T : unmanaged
                => Negate<T>.Op;

        [MethodImpl(Inline)]
        public static UnaryOp<T> inc<T>()
            where T : unmanaged
                => Inc<T>.Op;

        [MethodImpl(Inline)]
        public static UnaryOp<T> dec<T>()
            where T : unmanaged
                => Dec<T>.Op;

        [MethodImpl(Inline)]
        public static BinaryPred<T> eq<T>()
            where T : unmanaged
                => Eq<T>.Op;

        [MethodImpl(Inline)]
        public static BinaryPred<T> gt<T>()
            where T : unmanaged
                => Gt<T>.Op;

        [MethodImpl(Inline)]
        public static BinaryPred<T> gteq<T>()
            where T : unmanaged
                => GtEq<T>.Op;

        [MethodImpl(Inline)]
        public static BinaryPred<T> lt<T>()
            where T : unmanaged
                => Lt<T>.Op;

        [MethodImpl(Inline)]
        public static BinaryPred<T> lteq<T>()
            where T : unmanaged
                => LtEq<T>.Op;
                        
        [MethodImpl(Inline)]
        public static T add<T>(T lhs, T rhs)
            where T : unmanaged
                => gmath.add(lhs,rhs);
        
       [MethodImpl(Inline)]
        public static BinaryOp<T> and<T>()
            where T : unmanaged
                => And<T>.Op;

        [MethodImpl(Inline)]
        public static BinaryOp<T> or<T>()
            where T : unmanaged
                => Or<T>.Op;
 
        [MethodImpl(Inline)]
        public static BinaryOp<T> xor<T>()
            where T : unmanaged
                => XOr<T>.Op;

        [MethodImpl(Inline)]
        public static UnaryOp<T> flip<T>()
            where T : unmanaged
                => Flip<T>.Op;

        [MethodImpl(Inline)]
        public static Shifter<T> sal<T>(T lhs, int count)
            where T : unmanaged
                => Sal<T>.Op;

        [MethodImpl(Inline)]
        public static Shifter<T> sar<T>(T lhs, int count)
            where T : unmanaged
                => Sar<T>.Op;

       readonly struct Sal<T>
            where T : unmanaged
        {
            public static readonly Shifter<T> Op = gmath.sal<T>;
        }

       readonly struct Sar<T>
            where T : unmanaged
        {
            public static readonly Shifter<T> Op = gmath.sar<T>;
        }


        readonly struct And<T>
            where T : unmanaged
        {
            public static readonly BinaryOp<T> Op = gmath.and<T>;
        }


        readonly struct Or<T>
            where T : unmanaged
        {
            public static readonly BinaryOp<T> Op = gmath.or<T>;
        }

        readonly struct XOr<T>
            where T : unmanaged
        {
            public static readonly BinaryOp<T> Op = gmath.xor<T>;
        }

       readonly struct Flip<T>
            where T : unmanaged
        {
            public static readonly UnaryOp<T> Op = gmath.flip<T>;
        }
         
        readonly struct Add<T>
            where T : unmanaged
        {
            public static readonly BinaryOp<T> Op = add<T>;
        }

       readonly struct Sub<T>
            where T : unmanaged
        {
            public static readonly BinaryOp<T> Op = gmath.sub<T>;
        }

       readonly struct Mul<T>
            where T : unmanaged
        {
            public static readonly BinaryOp<T> Op = gmath.mul<T>;
        }

        readonly struct Div<T>
            where T : unmanaged
        {
            public static readonly BinaryOp<T> Op = gmath.div<T>;
        }

       readonly struct Mod<T>
            where T : unmanaged
        {
            public static readonly BinaryOp<T> Op = gmath.mod<T>;
        }

        readonly struct Negate<T>
            where T : unmanaged
        {
            public static readonly UnaryOp<T> Op = gmath.negate<T>;
        }    

       readonly struct Inc<T>
            where T : unmanaged
        {
            public static readonly UnaryOp<T> Op = gmath.inc<T>;
        }    

       readonly struct Dec<T>
            where T : unmanaged
        {
            public static readonly UnaryOp<T> Op = gmath.dec<T>;
        }    

        readonly struct Eq<T>
            where T : unmanaged
        {
            public static readonly BinaryPred<T> Op = gmath.eq<T>;
        }

       readonly struct Gt<T>
            where T : unmanaged
        {
            public static readonly BinaryPred<T> Op = gmath.gt<T>;
        }

       readonly struct Lt<T>
            where T : unmanaged
        {
            public static readonly BinaryPred<T> Op = gmath.lt<T>;
        }    

       readonly struct GtEq<T>
            where T : unmanaged
        {
            public static readonly BinaryPred<T> Op = gmath.gteq<T>;
        }

       readonly struct LtEq<T>
            where T : unmanaged
        {
            public static readonly BinaryPred<T> Op = gmath.lteq<T>;
        }    
   }

}