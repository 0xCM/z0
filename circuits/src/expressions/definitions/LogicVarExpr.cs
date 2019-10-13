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

    public sealed class LogicVarExpr : ILogicVarExpr
    {

        [MethodImpl(Inline)]
        public LogicVarExpr(string name, ILogicExpr init)
        {
            this.Name = name;
            this.Value = init;
        }

        /// <summary>
        /// The expression arity
        /// </summary>
        public ExprArity Arity => ExprArity.Unary;
        
        /// <summary>
        /// The variable name
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The varible value
        /// </summary>
        public ILogicExpr Value {get; private set;}

        [MethodImpl(Inline)]
        public void Set(ILogicExpr value)
        {
            this.Value = value;
        }

        [MethodImpl(Inline)]
        public void Set(LogicLitExpr value)
        {
            this.Value = value;
        }

        public string Format()
            => $"{Name} := {Value}";
        
        public override string ToString()
            => Format();
    }


}