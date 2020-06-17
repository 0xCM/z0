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
    /// Defines an untyped identified expression, identifier := expression
    /// </summary>
    public class FormulaExpr : IFormulaExpr
    {
        /// <summary>
        /// The identifier
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The identified expression
        /// </summary>
        public IExpr Encoding {get;}

        [MethodImpl(Inline)]
        public FormulaExpr(string name, IExpr encoding)
        {
            this.Name = name;
            this.Encoding = encoding;
        }        

        public string Format()
            => $"{Name} := {Encoding.Format()}";
    }

    /// <summary>
    /// Defines a typed identified expression, identifier := expression
    /// </summary>
    public sealed class FormulaExpr<T> : IFormulaExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The identifier
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The identified expression
        /// </summary>
        public IExpr<T> Encoding {get;}

        [MethodImpl(Inline)]
        public FormulaExpr(string name, IExpr<T> encoding)
        {
            this.Name = name;
            this.Encoding = encoding;
        }

        public string Format()
            => $"{Name} := {Encoding.Format()}";
    }
}