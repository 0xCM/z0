//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Option;

    using XPR = System.Linq.Expressions.Expression;

    partial class XPress
    {
        /// <summary>
        /// Defines a function that will invoke the default constructor to create
        /// an instance of type <typeparamref name="X"/>
        /// </summary>
        /// <typeparam name="X">The type of instance to create</typeparam>
        public static Option<Func<X>> factory<X>()
            => from c in ctor<X>()
                let x = XPR.New(c)
                select XPR.Lambda<Func<X>>(x).Compile();
        
        /// <summary>                                                               
        /// Defines a strongly-typed function that will invoke a one-parameter constructor to create a target type instance
        /// </summary>
        /// <typeparam name="X">The constructor parameter type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        public static Option<Func<X,T>> factory<X,T>()
            => from c in ctor<T>(typeof(X))
                let parameters = array(paramX<X>())
                let body = XPR.New(c, parameters)
                select lambda<Func<X,T>>(parameters, body).Compile();

        /// <summary>
        /// Defines a weakly-typed function that will invoke a one-parameter constructor to create a target type instance
        /// </summary>
        /// <param name="arg">The constuctor argument type</param>
        /// <param name="target">The target type</param>
        public static Option<Func<object, object>> factory(Type arg, Type target)
            => from c in ctor(target, arg)
                let cParams = array(paramX(arg))
                let lParams = array(paramX(typeof(object)))
                let converted = array(convert(lParams[0], arg))
                let body = XPR.New(c, converted)
                select lambda<Func<object, object>>(lParams, body).Compile();

        /// <summary>                                                               
        /// Defines a strongly-typed function that will invoke a two-parameter constructor to create a target type instance
        /// </summary>
        /// <typeparam name="X1">The first constructor parameter type</typeparam>
        /// <typeparam name="X2">The second constructor parameter type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        public static Option<Func<X1,X2,T>> factory<X1,X2,T>()
            => from c in ctor<X1,X2,T>()
                let parameters = paramX<X1,X2>()
                let body = XPR.New(c, parameters)
                select lambda<Func<X1,X2,T>>(parameters, body).Compile();

        /// <summary>
        /// Defines a weakly-typed function that will invoke a two-parameter constructor to create a target type instance
        /// </summary>
        /// <param name="arg1">The first constuctor parameter type</param>
        /// <param name="arg1">The second constuctor parameter type</param>
        /// <param name="target">The target type</param>
        public static Option<Func<object, object, object>> factory(Type arg1, Type arg2, Type target)
            => from c in ctor(target, arg1, arg2)
                let lParams = array(paramX<object>(), paramX<object>())
                let converted = array(convert(lParams[0], arg1), convert(lParams[1], arg2))
                let body = convert(XPR.New(c, converted), typeof(object))
                let final = lambda<Func<object, object, object>>(lParams, body)
                select final.Compile();

        /// <summary>                                                               
        /// Defines a strongly-typed function that will invoke a three-parameter constructor to create a target type instance
        /// </summary>
        /// <typeparam name="X1">The first constructor parameter type</typeparam>
        /// <typeparam name="X2">The second constructor parameter type</typeparam>
        /// <typeparam name="X3">The third constructor parameter type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        public static Option<Func<X1,X2,X3,T>> factory<X1,X2,X3,T>()
            => from c in ctor<X1,X2,T>()
                let parameters = paramX<X1,X2,X3>()
                let body = XPR.New(c, parameters)
                select lambda<Func<X1,X2,X3,T>>(parameters, body).Compile();
    }
}