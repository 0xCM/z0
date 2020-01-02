//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public sealed class VariableExpr<T> : IVarExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The name of the variable
        /// </summary>
        public string Name {get;}            

        /// <summary>
        /// The value of the variable
        /// </summary>
        public IExpr<T> Value {get; private set;}

        [MethodImpl(Inline)]
        public VariableExpr(string name, IExpr<T> value)
        {
            this.Value = value;
            this.Name = name;
        }
        
        /// <summary>
        /// Updates the variable's value
        /// </summary>
        /// <param name="value">The new value</param>
        [MethodImpl(Inline)]
        public void Set(IExpr<T> value)
        {
            Value = value;
        }

        [MethodImpl(Inline)]
        public void Set(T value)
        {
            Value = new LiteralExpr<T>(value);
        }

        [MethodImpl(Inline)]
        public void Set(IExpr value)
            => Value = (IExpr<T>)value;

        public string Format()
            => Format(false);

        public string Format(bool expand)
            => $"{Name}:{typename<T>()}" + (expand ? $" := {Value}" : string.Empty);
        
        public override string ToString()
            => Format();
    }
}