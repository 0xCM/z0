//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Rules
    {
        public interface IConstantExpression<T> : IExpression<T>
        {

        }

        public interface ILiteralExpression<T> : IConstantExpression<T>
        {

        }

        public interface IPrimitiveExpression<T> : ILiteralExpression<T>
            where T : unmanaged
        {

        }

        public interface IPredicateEvaluator<T>
            where T : IPredicate<T>
        {
            bool Evaluate(T predicate);
        }

        public interface IConstantRule<T> : IExpression<T>
            where T : IExpression<T>
        {

        }

    }
}