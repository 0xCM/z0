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
        public static Add<T> add<T>(T t = default)
            where T : unmanaged        
                => Add<T>.Op;

        [MethodImpl(Inline)]
        public static Sub<T> sub<T>(T t = default)
            where T : unmanaged        
                => Sub<T>.Op;

        [MethodImpl(Inline)]
        public static Mul<T> mul<T>(T t = default)
            where T : unmanaged        
                => Mul<T>.Op;

        [MethodImpl(Inline)]
        public static Div<T> div<T>(T t = default)
            where T : unmanaged        
                => Div<T>.Op;

        [MethodImpl(Inline)]
        public static ModOp<T> mod<T>(T t = default)
            where T : unmanaged        
                => ModOp<T>.Op;

        [MethodImpl(Inline)]
        public static ModMul<T> modmul<T>(T t = default)
            where T : unmanaged        
                => ModMul<T>.Op;

        [MethodImpl(Inline)]
        public static Even<T> even<T>(T t = default)
            where T : unmanaged        
                => Even<T>.Op;

        [MethodImpl(Inline)]
        public static Odd<T> odd<T>(T t = default)
            where T : unmanaged        
                => Odd<T>.Op;

        [MethodImpl(Inline)]
        public static Clamp<T> clamp<T>(T t = default)
            where T : unmanaged        
                => Clamp<T>.Op;

        [MethodImpl(Inline)]
        public static Square<T> square<T>(T t = default)
            where T : unmanaged        
                => Square<T>.Op;

        [MethodImpl(Inline)]
        public static Negate<T> negate<T>(T t = default)
            where T : unmanaged        
                => Negate<T>.Op;

        [MethodImpl(Inline)]
        public static Dec<T> dec<T>(T t = default)
            where T : unmanaged        
                => Dec<T>.Op;

        [MethodImpl(Inline)]
        public static Inc<T> inc<T>(T t = default)
            where T : unmanaged        
                => Inc<T>.Op;

        [MethodImpl(Inline)]
        public static Abs<T> abs<T>(T t = default)
            where T : unmanaged        
                => Abs<T>.Op;

       // ~ comparison
       // ~ ------------------------------------------------------------------

        [MethodImpl(Inline)]
        public static Eq<T> eq<T>(T t = default)
            where T : unmanaged        
                => Eq<T>.Op;

        [MethodImpl(Inline)]
        public static Neq<T> neq<T>(T t = default)
            where T : unmanaged        
                => Neq<T>.Op;

        [MethodImpl(Inline)]
        public static Lt<T> lt<T>(T t = default)
            where T : unmanaged        
                => Lt<T>.Op;

        [MethodImpl(Inline)]
        public static LtEq<T> lteq<T>(T t = default)
            where T : unmanaged        
                => LtEq<T>.Op;

        [MethodImpl(Inline)]
        public static Gt<T> gt<T>(T t = default)
            where T : unmanaged        
                => Gt<T>.Op;

        [MethodImpl(Inline)]
        public static GtEq<T> gteq<T>(T t = default)
            where T : unmanaged        
                => GtEq<T>.Op;

        [MethodImpl(Inline)]
        public static Between<T> between<T>(T t = default)
            where T : unmanaged        
                => Between<T>.Op;

        [MethodImpl(Inline)]
        public static Nonz<T> nonz<T>(T t = default)
            where T : unmanaged        
                => Nonz<T>.Op;

        [MethodImpl(Inline)]
        public static PositiveOp<T> positive<T>(T t = default)
            where T : unmanaged        
                => PositiveOp<T>.Op;

        [MethodImpl(Inline)]
        public static NegativeOp<T> negative<T>(T t = default)
            where T : unmanaged        
                => NegativeOp<T>.Op;

       // ~ bitwise
       // ~ ------------------------------------------------------------------
       
       [MethodImpl(Inline)]
       public static And<T> and<T>(T t = default)
            where T : unmanaged        
                => And<T>.Op;
 
        [MethodImpl(Inline)]
        public static Or<T> or<T>(T t = default)
            where T : unmanaged        
                => Or<T>.Op;

        [MethodImpl(Inline)]
        public static Xor<T> xor<T>(T t = default)
            where T : unmanaged        
                => Xor<T>.Op;

        [MethodImpl(Inline)]
        public static Nand<T> nand<T>(T t = default)
            where T : unmanaged        
                => Nand<T>.Op;

        [MethodImpl(Inline)]
        public static Nor<T> nor<T>(T t = default)
            where T : unmanaged        
                => Nor<T>.Op;

        [MethodImpl(Inline)]
        public static Xnor<T> xnor<T>(T t = default)
            where T : unmanaged        
                => Xnor<T>.Op;

        [MethodImpl(Inline)]
        public static Select<T> select<T>(T t = default)
            where T : unmanaged        
                => Select<T>.Op;

        [MethodImpl(Inline)]
        public static NotOp<T> not<T>(T t = default)
            where T : unmanaged        
                => NotOp<T>.Op;

        [MethodImpl(Inline)]
        public static Sll<T> sll<T>(T t = default)
            where T : unmanaged        
                => Sll<T>.Op;

        [MethodImpl(Inline)]
        public static Srl<T> srl<T>(T t = default)
            where T : unmanaged        
                => Srl<T>.Op;

        [MethodImpl(Inline)]
        public static Parse<T> parse<T>(T t = default)
            where T : unmanaged        
                => Parse<T>.Op;
    }
}