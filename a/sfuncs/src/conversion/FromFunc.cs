//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;
    
    using static Core;
    using S = Surrogates;

    public static partial class OperationConverters
    {
        [MethodImpl(Inline)]
        public static S.Emitter<T> ToEmitter<T>(this S.Func<T> src)
            => S.emitter(src.Subject.ToEmitter(), src.Id);

        [MethodImpl(Inline)]
        public static S.UnaryOp<T> ToUnaryOp<T>(this S.Func<T,T> src)
            => S.unary(src.Subject.ToUnaryOp(), src.Id);

        [MethodImpl(Inline)]
        public static S.BinaryOp<T> ToBinaryOp<T>(this S.Func<T,T,T> src)
            => S.binary(src.Subject.ToBinaryOp(), src.Id);

        [MethodImpl(Inline)]
        public static S.TernaryOp<T> ToTernaryOp<T>(this S.Func<T,T,T,T> src)
            => S.ternary(src.Subject.ToTernaryOp(), src.Id);
    }
}