//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;
    
    using static SFuncs;
    using S = Surrogates;

    public static partial class OperationConverters
    {
        [MethodImpl(Inline)]
        public static S.Func<T> ToFunc<T>(this S.Emitter<T> src)
            => new S.Func<T>(src.Subject.ToFunc(), src.Id);

        [MethodImpl(Inline)]
        public static S.Func<T,T> ToFunc<T>(this S.UnaryOp<T> src)
            => new S.Func<T,T>(src.Subject.ToFunc(), src.Id);

        [MethodImpl(Inline)]
        public static S.Func<T,T,T> ToFunc<T>(this S.BinaryOp<T> src)
            => new S.Func<T,T,T>(src.Subject.ToFunc(), src.Id);

        [MethodImpl(Inline)]
        public static S.Func<T,T,T,T> ToFunc<T>(this S.TernaryOp<T> src)
            => new S.Func<T,T,T,T>(src.Subject.ToFunc(), src.Id);

        [MethodImpl(Inline)]
        public static S.Func<T,bit> ToFunc<T>(this S.UnaryPredicate<T> src)
            => new S.Func<T,bit>(src.Subject.ToFunc(), src.Id);

        [MethodImpl(Inline)]
        public static S.Func<T,T,bit> ToFunc<T>(this S.BinaryPredicate<T> src)
            => new S.Func<T,T,bit>(src.Subject.ToFunc(), src.Id);
    }
}