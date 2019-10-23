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

    /// <summary>
    /// Defines a variable expression for which variable values are fully evaluated, i.e. are literals
    /// </summary>
    /// <typeparam name="T">The type over which the expression is defined</typeparam>
    public sealed class LiteralVarExpr<T> : ILiteralVarExpr<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public LiteralVarExpr(string name, T value)
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
        public T Value {get; private set;}
        
        IExpr IVarExpr.Value 
            => new LiteralExpr<T>(Value);

        /// <summary>
        /// Updates the variable's value
        /// </summary>
        /// <param name="value">The new value</param>
        [MethodImpl(Inline)]
        public void Set(T value)
        {
            Value = value;
        }

        [MethodImpl(Inline)]
        public void Set(IExpr value)
            => Value = ((ILiteralExpr<T>)value).Value;

        public string Format()
            => Format(false);

        public string Format(bool expand)
            => $"{Name}:{typename<T>()}" + (expand ? $" := {Value}" : string.Empty);
        
        public override string ToString()
            => Format();
    }
}