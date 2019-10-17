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


    }

}