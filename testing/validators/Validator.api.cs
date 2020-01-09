//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public static class Validators
    {
        public static IUnaryValidator<T,T> UnaryValidator<T>(this ITestContext context, T t = default)
            where T : unmanaged
                => new UnaryValidator<T,T>(context);

        public static IUnaryValidator<T,T> UnaryValidator<T>(this ITestContext context, bool xzero, T t = default)
            where T : unmanaged
                => new UnaryValidator<T,T>(context,xzero);

        public static IBinaryValidator<T,T,T> BinaryValidator<T>(this ITestContext context, T t = default)
            where T : unmanaged
                => new BinaryValidator<T,T,T>(context);

        public static IBinaryValidator<T,T,T> BinaryValidator<T>(this ITestContext context, bool xzero, T t = default)
            where T : unmanaged
            => new BinaryValidator<T,T,T>(context,xzero);

        public static IBinaryValidator<T,T,bit> BinaryPredicateValidator<T>(this ITestContext context, T t = default)
            where T : unmanaged
                => new BinaryValidator<T,T,bit>(context);

        public static ITernaryValidator<T,T,T,T> TernaryValidator<T>(this ITestContext context, T t = default)
            where T : unmanaged
                => new TernaryValidator<T,T,T,T>(context);

        public static ITernaryValidator<T,T,T,bit> TernaryPredicateValidator<T>(this ITestContext context, T t = default)
            where T : unmanaged
                => new TernaryValidator<T,T,T,bit>(context);

        public static ITernaryValidator<T,T,T,T> TernaryValidator<T>(this ITestContext context, bool xzero = false, T t = default)
            where T : unmanaged
                => new TernaryValidator<T,T,T,T>(context,xzero);
    }

    abstract class Validator
    {
        protected Validator(ITestContext context, bool xzero = false)
        {
            this.Context = context;
            this.ExcludeZero = xzero;
        }
        
        protected ITestContext Context {get;}

        protected IPolyrand Random
            => Context.Random;

        public int RepCount
            => Context.RepCount;

        protected bool ExcludeZero {get;}
    }

}
