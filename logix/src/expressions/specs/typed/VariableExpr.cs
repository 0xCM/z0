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

    public sealed class VariableExpr<T> : IVarExpr<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public VariableExpr(string name, ITypedExpr<T> value)
        {
            this.Value = value;
            this.Name = name;
        }

        /// <summary>
        /// The expression classifier
        /// </summary>
        public TypedExprKind ExprKind 
            => TypedExprKind.Variable;


        /// <summary>
        /// The name of the variable
        /// </summary>
        public string Name {get;}            

        /// <summary>
        /// The value of the variable
        /// </summary>
        public ITypedExpr<T> Value {get; private set;}
        
        IExpr IVarExpr.Value 
            => Value;

        /// <summary>
        /// Updates the variable's value
        /// </summary>
        /// <param name="value">The new value</param>
        [MethodImpl(Inline)]
        public void Set(ITypedExpr<T> value)
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
            => Value = (ITypedExpr<T>)value;

        public string Format()
            => Format(false);

        public string Format(bool expand)
            => $"{Name}:{typename<T>()}" + (expand ? $" := {Value}" : string.Empty);
        
        public override string ToString()
            => Format();
    }
}