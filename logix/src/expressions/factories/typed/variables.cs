//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public static partial class TypedLogicSpec
    {
        /// <summary>
        /// Defines a variable expression
        /// </summary>
        /// <param name="value">The initial value of the variable</param>
        /// <typeparam name="T">The variable type</typeparam>
        [MethodImpl(Inline)]
        public static Variable<T> variable<T>(string name, IExpr<T> value)
            where T : unmanaged
                => new Variable<T>(name, value);

        /// <summary>
        /// Defines a bit variable expression where the variable name is defined by an integer
        /// </summary>
        /// <param name="name">The variable's name</param>
        /// <param name="init">The variable's initial value</param>
        [MethodImpl(Inline)]
        public static Variable<T> variable<T>(uint name, IExpr<T> init)
            where T : unmanaged
            => new Variable<T>(name.ToString(), init);

        /// <summary>
        /// Defines a variable expression with an initial value specified by a literal
        /// </summary>
        /// <param name="value">The initial value of the variable</param>
        /// <typeparam name="T">The variable type</typeparam>
        [MethodImpl(Inline)]
        public static Variable<T> variable<T>(string name, T value = default)
            where T : unmanaged
                => new Variable<T>(name, literal(value));

        /// <summary>
        /// Defines a variable expression where the variable name is defined by an integer and 
        /// an initial value is specified by a literal
        /// </summary>
        /// <param name="value">The initial value of the variable</param>
        /// <typeparam name="T">The variable type</typeparam>
        [MethodImpl(Inline)]
        public static Variable<T> variable<T>(uint name, T value = default)
            where T : unmanaged
                => new Variable<T>(name.ToString(), literal(value));        

        /// <summary>
        /// Creates a varied expression predicated on a typed variable sequence
        /// </summary>
        /// <param name="subject">The variable-dependent expression</param>
        /// <param name="variables">The variable sequence</param>
        [MethodImpl(Inline)]
        public static VariedExpr<T> varied<T>(IExpr<T> baseExpr, params Variable<T>[] variables)
            where T : unmanaged             
                => VariedExpr.Define(baseExpr, variables);

        /// <summary>
        /// Creates a varied expression predicated on a typed variable sequence of natural length
        /// </summary>
        /// <param name="subject">The variable-dependent expression</param>
        /// <param name="variables">The variable sequence</param>
        [MethodImpl(Inline)]
        public static VariedExpr<N,T> varied<N,T>(N n, IExpr<T> baseExpr, params Variable<T>[] variables)
            where T : unmanaged             
            where N : unmanaged, ITypeNat
                => VariedExpr.Define(n, baseExpr, variables);

        /// <summary>
        /// Defines a varied expression of 1 variable
        /// </summary>
        /// <param name="n">The number of variables in the expression</param>
        /// <param name="baseExpr">The variable-dependent expression </param>
        /// <param name="v0">The variable</param>
        /// <typeparam name="T">The type over which the expression is defined</typeparam>
        [MethodImpl(Inline)]
        public static VariedExpr<N1,T> varied<T>(N1 n, IExpr<T> baseExpr, Variable<T> v0)
            where T : unmanaged             
                => VariedExpr.Define(n, baseExpr, v0);

        /// <summary>
        /// Defines a varied expression of 2 variables
        /// </summary>
        /// <param name="n">The number of variables in the expression</param>
        /// <param name="baseExpr">The variable-dependent expression </param>
        /// <param name="v0">The first variable</param>
        /// <param name="v1">The second variable</param>
        /// <typeparam name="T">The type over which the expression is defined</typeparam>
        [MethodImpl(Inline)]
        public static VariedExpr<N2,T> varied<T>(N2 n, IExpr<T> baseExpr, Variable<T> v0, Variable<T> v1)
            where T : unmanaged             
                => VariedExpr.Define(n, baseExpr, v0, v1);

        /// <summary>
        /// Defines a varied expression of 3 variables
        /// </summary>
        /// <param name="n">The number of variables in the expression</param>
        /// <param name="baseExpr">The variable-dependent expression </param>
        /// <param name="v0">The first variable</param>
        /// <param name="v1">The second variable</param>
        /// <param name="v2">The third variable</param>
        /// <typeparam name="T">The type over which the expression is defined</typeparam>
        [MethodImpl(Inline)]
        public static VariedExpr<N3,T> varied<T>(N3 n, IExpr<T> baseExpr, Variable<T> v0, Variable<T> v1, Variable<T> v2)
            where T : unmanaged             
                => VariedExpr.Define(n, baseExpr, v0, v1, v2);

    }

}