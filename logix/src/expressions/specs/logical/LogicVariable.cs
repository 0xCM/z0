//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public sealed class LogicVariable : ILogicVariable
    {

        [MethodImpl(Inline)]
        public LogicVariable(string name, ILogicExpr init)
        {
            this.Name = name;
            this.Value = init;
        }

        [MethodImpl(Inline)]
        public LogicVariable(string name, bit init)
        {
            this.Name = name;
            this.Value = new LiteralLogicExpr(init);
        }

        /// <summary>
        /// The expression classifier
        /// </summary>
        public LogicExprKind ExprKind
            => LogicExprKind.Variable;

        /// <summary>
        /// The variable name
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The varible value
        /// </summary>
        public ILogicExpr Value {get; private set;}

        IExpr IVariable.Value 
            => Value;

        [MethodImpl(Inline)]
        public void Set(ILogicExpr value)
        {
            this.Value = value;
        }

        [MethodImpl(Inline)]
        public void Set(bit value)
        {
            this.Value = new LiteralLogicExpr(value);
        }


        [MethodImpl(Inline)]
        public void Set(IExpr value)
            => Value = (ILogicExpr)value;

        public string Format()
            => Format(false);

        public string Format(bool expand)
            => $"{Name}" + (expand ? $" := {Value}" : string.Empty);
        
        public override string ToString()
            => Format();

    }


}