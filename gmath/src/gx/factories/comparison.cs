//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;
    using static GXTypes;

    partial class GX
    {
        // public static IBinaryOp<T> lookup<T>(BinaryBitwiseOpKind kind)
        //     where T : unmanaged
        // {
        //     switch(kind)
        //     {
        //         case BinaryBitwiseOpKind.True: return @true;
        //         case BinaryBitwiseOpKind.False: return @false;
        //         case BinaryBitwiseOpKind.And: return and<T>();
        //         case BinaryBitwiseOpKind.Nand: return nand<T>();
        //         case BinaryBitwiseOpKind.Or: return or<T>();
        //         case BinaryBitwiseOpKind.Nor: return nor<T>();
        //         case BinaryBitwiseOpKind.XOr: return xor<T>();
        //         case BinaryBitwiseOpKind.Xnor: return xnor<T>();
        //         case BinaryBitwiseOpKind.LeftProject: return left();
        //         case BinaryBitwiseOpKind.RightProject: return right;
        //         case BinaryBitwiseOpKind.LeftNot: return lnot;
        //         case BinaryBitwiseOpKind.RightNot: return rnot;
        //         case BinaryBitwiseOpKind.Implication: return imply<T>();
        //         case BinaryBitwiseOpKind.Nonimplication: return notimply<T>();
        //         case BinaryBitwiseOpKind.ConverseImplication: return cimply<T>();
        //         case BinaryBitwiseOpKind.ConverseNonimplication: return cnotimply<T>();
        //         default: return dne<T>(kind);
        //     }
        // }


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

        [MethodImpl(Inline)]
        public static Min<T> min<T>(T t = default)
            where T : unmanaged        
                => Min<T>.Op;

        [MethodImpl(Inline)]
        public static Max<T> max<T>(T t = default)
            where T : unmanaged        
                => Max<T>.Op;
    }
}