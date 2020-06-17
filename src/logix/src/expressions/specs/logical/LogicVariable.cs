//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    /// <summary>
    /// Defines an untyped logic variable
    /// </summary>
    public sealed class LogicVariable : ILogicVarExpr
    {
        /// <summary>
        /// The variable name
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The varible value
        /// </summary>
        public ILogicExpr Value {get; private set;}

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