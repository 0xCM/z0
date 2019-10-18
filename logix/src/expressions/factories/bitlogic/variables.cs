//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    
    partial class BitLogicSpec
    {
        /// <summary>
        /// Defines a bit variable expression initialized to a literal value
        /// </summary>
        /// <param name="name">The variable's name</param>
        /// <param name="init">The variable's initial value</param>
        [MethodImpl(Inline)]
        public static LogicVariable variable(string name, bit init = default)
            => new LogicVariable(name, init);

        /// <summary>
        /// Defines a bit variable expression initialized to a literal value
        /// and the variable name is defined by an integer
        /// </summary>
        /// <param name="name">The variable's name</param>
        /// <param name="init">The variable's initial value</param>
        [MethodImpl(Inline)]
        public static LogicVariable variable(uint name, bit init = default)
            => variable(name.ToString(),init);

        /// <summary>
        /// Creates a varied expression predicated on a specified variable sequence
        /// </summary>
        /// <param name="subject">The variable-dependent expression</param>
        /// <param name="variables">The variable sequence</param>
        [MethodImpl(Inline)]
        public static VariedLogicExpr varied(ILogicExpr subject, params IlogicVariable[] variables)
            => VariedLogicExpr.Define(subject, variables);

        /// <summary>
        /// Creates a varied expression predicated on a specified variable sequence of natural length
        /// </summary>
        /// <param name="n">The natural length of the variable sequence</param>
        /// <param name="subject">The variable-dependent expression</param>
        /// <param name="variables">The variable sequence</param>
        [MethodImpl(Inline)]
        public static VariedLogicExpr<N> varied<N>(N n, ILogicExpr subject, params IlogicVariable[] variables)
            where N : unmanaged, ITypeNat
                => VariedLogicExpr.Define(n,subject, variables);

    }

}