//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a typed logic variable expression
    /// </summary>
     public sealed class LogicVariable<T> : ILogicVarExpr<T>
        where T : unmanaged
    {
        public uint Symbol {get;}

        /// <summary>
        /// The variable name
        /// </summary>
        public string Name => Symbol.ToString();

        /// <summary>
        /// The variable value
        /// </summary>
        public ILogicExpr<T> Value {get; private set;}

        [MethodImpl(Inline)]
        internal LogicVariable(uint symbol, ILogicExpr<T> init)
        {
            Symbol = symbol;
            Value = init;
        }

        [MethodImpl(Inline)]
        internal LogicVariable(uint symbol, Bit32 init)
        {
            Symbol = symbol;
            Value = new LiteralLogicExpr<T>(init);
        }

        ILogicExpr ILogicVarExpr.Value
            => Value;

        [MethodImpl(Inline)]
        public void Set(ILogicExpr value)
            => Value = (ILogicExpr<T>)value;

        [MethodImpl(Inline)]
        public void Set(ILogicExpr<T> value)
            => Value = value;

        [MethodImpl(Inline)]
        public void Set(Bit32 value)
            => Value = new LiteralLogicExpr<T>(value);

        public string Format()
            => Format(false);

        public string Format(bool expand)
            => $"{Name}" + (expand ? $" := {Value}" : string.Empty);

        public override string ToString()
            => Format();
    }
}