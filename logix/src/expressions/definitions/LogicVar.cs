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

    public sealed class LogicVar : ILogicVar
    {

        [MethodImpl(Inline)]
        public LogicVar(string name, IExpr<Bit> init)
        {
            this.Name = name;
            this.Value = init;
        }

        /// <summary>
        /// The expression arity
        /// </summary>
        public ArityKind Arity => ArityKind.Unary;
        
        /// <summary>
        /// The variable name
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The varible value
        /// </summary>
        public IExpr<Bit> Value {get; private set;}


        IExpr IVarExpr.Value 
            => Value;

        [MethodImpl(Inline)]
        public void Set(IExpr<Bit> value)
        {
            this.Value = value;
        }

        [MethodImpl(Inline)]
        public void Set(Bit value)
        {
            this.Value = new BitLiteral(value);
        }

        public string Format()
            => $"{Name} := {Value}";
        
        public override string ToString()
            => Format();


        public void Set(IExpr value)
            => Value = (IExpr<Bit>)value;
    }


}