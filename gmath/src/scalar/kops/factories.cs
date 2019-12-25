//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;
    using static KOpStructs;

    public static class KOps
    {
       // ~ arithmetic
       // ~ ------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static Add<T> add<T>()
            where T : unmanaged        
                => Add<T>.Op;

        [MethodImpl(Inline)]
        public static Sub<T> sub<T>()
            where T : unmanaged        
                => Sub<T>.Op;

        [MethodImpl(Inline)]
        public static Mul<T> mul<T>()
            where T : unmanaged        
                => Mul<T>.Op;

        [MethodImpl(Inline)]
        public static Div<T> div<T>()
            where T : unmanaged        
                => Div<T>.Op;

        [MethodImpl(Inline)]
        public static ModOp<T> mod<T>()
            where T : unmanaged        
                => ModOp<T>.Op;

        [MethodImpl(Inline)]
        public static Even<T> even<T>()
            where T : unmanaged        
                => Even<T>.Op;

        [MethodImpl(Inline)]
        public static Odd<T> odd<T>()
            where T : unmanaged        
                => Odd<T>.Op;

        [MethodImpl(Inline)]
        public static Clamp<T> clamp<T>()
            where T : unmanaged        
                => Clamp<T>.Op;

        [MethodImpl(Inline)]
        public static Square<T> square<T>()
            where T : unmanaged        
                => Square<T>.Op;

        [MethodImpl(Inline)]
        public static Negate<T> negate<T>()
            where T : unmanaged        
                => Negate<T>.Op;

        [MethodImpl(Inline)]
        public static Dec<T> dec<T>()
            where T : unmanaged        
                => Dec<T>.Op;

        [MethodImpl(Inline)]
        public static Inc<T> inc<T>()
            where T : unmanaged        
                => Inc<T>.Op;

        [MethodImpl(Inline)]
        public static Abs<T> abs<T>()
            where T : unmanaged        
                => Abs<T>.Op;

       // ~ comparison
       // ~ ------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static Eq<T> eq<T>()
            where T : unmanaged        
                => Eq<T>.Op;

        [MethodImpl(Inline)]
        public static Neq<T> neq<T>()
            where T : unmanaged        
                => Neq<T>.Op;

        [MethodImpl(Inline)]
        public static Lt<T> lt<T>()
            where T : unmanaged        
                => Lt<T>.Op;

        [MethodImpl(Inline)]
        public static LtEq<T> lteq<T>()
            where T : unmanaged        
                => LtEq<T>.Op;

        [MethodImpl(Inline)]
        public static Gt<T> gt<T>()
            where T : unmanaged        
                => Gt<T>.Op;

        [MethodImpl(Inline)]
        public static GtEq<T> gteq<T>()
            where T : unmanaged        
                => GtEq<T>.Op;

        [MethodImpl(Inline)]
        public static Between<T> between<T>()
            where T : unmanaged        
                => Between<T>.Op;

        [MethodImpl(Inline)]
        public static Nonz<T> nonz<T>()
            where T : unmanaged        
                => Nonz<T>.Op;

        [MethodImpl(Inline)]
        public static PositiveOp<T> positive<T>()
            where T : unmanaged        
                => PositiveOp<T>.Op;

        [MethodImpl(Inline)]
        public static NegativeOp<T> negative<T>()
            where T : unmanaged        
                => NegativeOp<T>.Op;

       // ~ bitwise
       // ~ ------------------------------------------------------------------
       
       [MethodImpl(Inline)]
       public static And<T> and<T>()
            where T : unmanaged        
                => And<T>.Op;
 
        [MethodImpl(Inline)]
        public static Or<T> or<T>()
            where T : unmanaged        
                => Or<T>.Op;

        [MethodImpl(Inline)]
        public static And<T> xor<T>()
            where T : unmanaged        
                => default;

        [MethodImpl(Inline)]
        public static Nand<T> nand<T>()
            where T : unmanaged        
                => Nand<T>.Op;

        [MethodImpl(Inline)]
        public static Nor<T> nor<T>()
            where T : unmanaged        
                => Nor<T>.Op;

        [MethodImpl(Inline)]
        public static Xnor<T> xnor<T>()
            where T : unmanaged        
                => Xnor<T>.Op;

        [MethodImpl(Inline)]
        public static Select<T> select<T>()
            where T : unmanaged        
                => Select<T>.Op;

        [MethodImpl(Inline)]
        public static NotOp<T> not<T>()
            where T : unmanaged        
                => NotOp<T>.Op;

        [MethodImpl(Inline)]
        public static Sll<T> sll<T>()
            where T : unmanaged        
                => Sll<T>.Op;

        [MethodImpl(Inline)]
        public static Srl<T> srl<T>()
            where T : unmanaged        
                => Srl<T>.Op;

        [MethodImpl(Inline)]
        public static Parse<T> parse<T>()
            where T : unmanaged        
                => Parse<T>.Op;
    }
}