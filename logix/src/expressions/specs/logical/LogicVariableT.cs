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

     public sealed class LogicVariable<T> : ILogicVarExpr<T>
        where T : unmanaged
    {

        [MethodImpl(Inline)]
        public LogicVariable(string name, ILogicExpr<T> init)
        {
            this.Name = name;
            this.Value = init;
        }

        [MethodImpl(Inline)]
        public LogicVariable(string name, bit init)
        {
            this.Name = name;
            this.Value = new LiteralLogicExpr<T>(init);
        }

        /// <summary>
        /// The variable name
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The varible value
        /// </summary>
        public ILogicExpr<T> Value {get; private set;}

        ILogicExpr ILogicVarExpr.Value 
            => Value;

        [MethodImpl(Inline)]
        public void Set(ILogicExpr value)
        {
            this.Value = (ILogicExpr<T>)value;
        }

        [MethodImpl(Inline)]
        public void Set(ILogicExpr<T> value)
        {
            this.Value = value;
        }

        [MethodImpl(Inline)]
        public void Set(bit value)
        {
            this.Value = new LiteralLogicExpr<T>(value);
        }



        public string Format()
            => Format(false);

        public string Format(bool expand)
            => $"{Name}" + (expand ? $" := {Value}" : string.Empty);
        
        public override string ToString()
            => Format();

    }
}