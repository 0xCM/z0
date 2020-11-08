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
        /// <summary>
        /// Characterizes an expression that is reducible to an expression that evaluates to a boolean value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public interface IBooleanExpression<T> : IExpression<T>
        {

        }
    }
}