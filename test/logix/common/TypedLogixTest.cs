//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;

    using static Seed;
    using static Memories;
    using static TypedLogicSpec;

    public abstract class TypedLogixTest<X> : LogixTest<X>
        where X : TypedLogixTest<X>
    {
        /// <summary>
        /// Creates a typed variable named 'a'
        /// </summary>
        /// <typeparam name="V">The variable's underlying type</typeparam>
        protected static VariableExpr<V> var_a<V>()
            where V : unmanaged
                => variable<V>(Letters.a);

        /// <summary>
        /// Creates a typed variable named 'b'
        /// </summary>
        /// <typeparam name="V">The variable's underlying type</typeparam>
        protected static VariableExpr<V> var_b<V>()
            where V : unmanaged
                => variable<V>(Letters.b);

        /// <summary>
        /// Creates a typed variable named 'c'
        /// </summary>
        /// <typeparam name="V">The variable's underlying type</typeparam>
        protected static VariableExpr<V> var_c<V>()
            where V : unmanaged
                => variable<V>(Letters.c);

        /// <summary>
        /// Creates a typed variable named 'x'
        /// </summary>
        /// <typeparam name="V">The variable's underlying type</typeparam>
        protected static VariableExpr<V> var_x<V>()
            where V : unmanaged
                => variable<V>(Letters.a);

        /// <summary>
        /// Creates a typed variable named 'y'
        /// </summary>
        /// <typeparam name="V">The variable's underlying type</typeparam>
        protected static VariableExpr<V> var_y<V>()
            where V : unmanaged
                => variable<V>(Letters.b);

        /// <summary>
        /// Creates a typed variable named 'z'
        /// </summary>
        /// <typeparam name="V">The variable's underlying type</typeparam>
        protected static VariableExpr<V> var_z<V>()
            where V : unmanaged
                => variable<V>(Letters.c);
   }
}