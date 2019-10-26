//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static ArithmeticSpec;
    using static TypedLogicSpec;

    using static LogicEngine;

    public abstract class TypedLogixTest<T> : UnitTest<T>
        where T : TypedLogixTest<T>
    {

        /// <summary>
        /// Creates a typed variable named 'a'
        /// </summary>
        /// <typeparam name="V">The variable's underlying type</typeparam>
        protected static VariableExpr<V> var_a<V>()
            where V : unmanaged
                => variable<V>(AsciLower.a);

        /// <summary>
        /// Creates a typed variable named 'b'
        /// </summary>
        /// <typeparam name="V">The variable's underlying type</typeparam>
        protected static VariableExpr<V> var_b<V>()
            where V : unmanaged
                => variable<V>(AsciLower.b);

        /// <summary>
        /// Creates a typed variable named 'c'
        /// </summary>
        /// <typeparam name="V">The variable's underlying type</typeparam>
        protected static VariableExpr<V> var_c<V>()
            where V : unmanaged
                => variable<V>(AsciLower.c);

        /// <summary>
        /// Creates a typed variable named 'x'
        /// </summary>
        /// <typeparam name="V">The variable's underlying type</typeparam>
        protected static VariableExpr<V> var_x<V>()
            where V : unmanaged
                => variable<V>(AsciLower.a);

        /// <summary>
        /// Creates a typed variable named 'y'
        /// </summary>
        /// <typeparam name="V">The variable's underlying type</typeparam>
        protected static VariableExpr<V> var_y<V>()
            where V : unmanaged
                => variable<V>(AsciLower.b);

        /// <summary>
        /// Creates a typed variable named 'z'
        /// </summary>
        /// <typeparam name="V">The variable's underlying type</typeparam>
        protected static VariableExpr<V> var_z<V>()
            where V : unmanaged
                => variable<V>(AsciLower.c);

    }

}