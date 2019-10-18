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

    public sealed class Variable<T> : IVariable<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public Variable(string name, IExpr<T> value)
        {
            this.Value = value;
            this.Name = name;
        }

        /// <summary>
        /// The name of the variable
        /// </summary>
        public string Name {get;}            

        /// <summary>
        /// The value of the variable
        /// </summary>
        public IExpr<T> Value {get; private set;}
        
        IExpr IVariable.Value 
            => Value;

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
            Value = new Literal<T>(value);
        }

        [MethodImpl(Inline)]
        public void Set(IExpr value)
            => Value = (IExpr<T>)value;

        public string Format()
            => Format(true);

        public string Format(bool withValue)
            => $"v_{Name}" + (withValue ? $" := {Value}" : string.Empty);
        
        public override string ToString()
            => Format();
    }
}