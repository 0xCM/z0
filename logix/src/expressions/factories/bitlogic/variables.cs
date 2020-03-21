//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;
    
    partial class BitLogicSpec
    {
        /// <summary>
        /// Defines a bit variable expression initialized to a literal value
        /// </summary>
        /// <param name="name">The variable's name</param>
        /// <param name="init">The variable's initial value</param>
        [MethodImpl(Inline)]
        public static LogicVariable lvar(string name, bit init = default)
            => new LogicVariable(name, init);

        /// <summary>
        /// Defines a bit variable expression initialized to a literal value
        /// </summary>
        /// <param name="name">The variable's single-character name</param>
        /// <param name="init">The variable's initial value</param>
        [MethodImpl(Inline)]
        public static LogicVariable lvar(char name, bit init = default)
            => new LogicVariable(name.ToString(), init);

        /// <summary>
        /// Defines a bit variable expression initialized to a literal value
        /// and the variable name is defined by an integer
        /// </summary>
        /// <param name="name">The variable's name</param>
        /// <param name="init">The variable's initial value</param>
        [MethodImpl(Inline)]
        public static LogicVariable lvar(uint name, bit init = default)
            => lvar(name.ToString(),init);

        /// <summary>
        /// Defines a typed logic variable expression initialized to a literal value
        /// </summary>
        /// <param name="name">The variable's name</param>
        /// <param name="init">The variable's initial value</param>
        [MethodImpl(Inline)]
        public static LogicVariable<T> lvar<T>(string name, bit init = default)
            where T : unmanaged
                => new LogicVariable<T>(name, init);

        /// <summary>
        /// Defines a typed logic variable expression initialized to a literal value
        /// </summary>
        /// <param name="name">The variable's name</param>
        /// <param name="init">The variable's initial value</param>
        [MethodImpl(Inline)]
        public static LogicVariable<T> lvar<T>(string name, ILogicExpr<T> init)
            where T : unmanaged
                => new LogicVariable<T>(name, init);

        /// <summary>
        /// Defines a typed logic variable expression initialized to a literal value
        /// </summary>
        /// <param name="name">The variable's name</param>
        /// <param name="init">The variable's initial value</param>
        [MethodImpl(Inline)]
        public static LogicVariable<T> lvar<T>(char name, bit init = default)
            where T : unmanaged
                => new LogicVariable<T>(name.ToString(), init);

        /// <summary>
        /// Defines a typed logic variable expression initialized to a literal value
        /// </summary>
        /// <param name="name">The variable's name</param>
        /// <param name="init">The variable's initial value</param>
        [MethodImpl(Inline)]
        public static LogicVariable<T> lvar<T>(uint name, bit init = default)
            where T : unmanaged
                => new LogicVariable<T>(name.ToString(), init);

        /// <summary>
        /// Defines a specified number n of logic variable expressions where each variable is respectively named 0,..., n - 1
        /// </summary>
        /// <param name="n">The number of variables to define</param>
        public static LogicVariable[] lvars(int n)
        {
            var vars = new LogicVariable[n];
            for(var i =0; i<n; i++)
                vars[i] = lvar(i.ToString());
            return vars;
        }

        /// <summary>
        /// Defines a specified number n of typed logic variable expressions where each variable is respectively named 0,..., n - 1
        /// </summary>
        /// <param name="n">The number of variables to define</param>
        public static LogicVariable<T>[] lvars<T>(int n)
            where T : unmanaged
        {
            var vars = new LogicVariable<T>[n];
            for(var i =0; i<n; i++)
                vars[i] = lvar<T>(i.ToString());
            return vars;
        }

        /// <summary>
        /// Creates a varied expression predicated on a specified variable sequence
        /// </summary>
        /// <param name="expr">The variable-dependent expression</param>
        /// <param name="vars">The variable sequence</param>
        [MethodImpl(Inline)]
        public static VariedLogicExpr varied(ILogicExpr expr, params LogicVariable[] vars)
            => new VariedLogicExpr(expr, vars);

        /// <summary>
        /// Creates a varied expression predicated on a specified variable sequence
        /// </summary>
        /// <param name="expr">The variable-dependent expression</param>
        /// <param name="vars">The variable sequence</param>
        [MethodImpl(Inline)]
        public static VariedLogicExpr<T> varied<T>(ILogicExpr<T> expr, params LogicVariable<T>[] vars)
            where T : unmanaged
                => new VariedLogicExpr<T>(expr, vars); 
    }   
}