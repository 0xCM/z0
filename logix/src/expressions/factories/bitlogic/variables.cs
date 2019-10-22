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
        /// </summary>
        /// <param name="name">The variable's single-character name</param>
        /// <param name="init">The variable's initial value</param>
        [MethodImpl(Inline)]
        public static LogicVariable variable(char name, bit init = default)
            => new LogicVariable(name.ToString(), init);

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
        /// Defines a specified number n of logic variable expressions where
        /// each variable is respectively named 0,..., n - 1
        /// </summary>
        /// <param name="n">The number of variables to define</param>
        public static LogicVariable[] variables(int n)
        {
            var vars = new LogicVariable[n];
            for(var i =0; i<n; i++)
                vars[i] = variable(i.ToString());
            return vars;
        }
            
        /// <summary>
        /// Creates a varied expression predicated on a specified variable sequence
        /// </summary>
        /// <param name="subject">The variable-dependent expression</param>
        /// <param name="variables">The variable sequence</param>
        [MethodImpl(Inline)]
        public static VariedLogicExpr varied(ILogicExpr subject, params ILogicVariable[] variables)
            => VariedLogicExpr.Define(subject, variables);

        /// <summary>
        /// Defines an untyped test expression
        /// </summary>
        /// <param name="test">The logical operator to use for the test</param>
        /// <param name="lhs">The control expression</param>
        /// <param name="rhs">The test subject</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static EqualityExpr equals(ILogicExpr lhs, ILogicExpr rhs, params LogicVariable[] variables)
            => EqualityExpr.Define(lhs,rhs,variables);

    }   

}