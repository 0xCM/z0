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
    /// Defines a typed identified expression, identifier := expression
    /// </summary>
    public readonly struct FormulaExpr<T> : IFormulaExpr<T>
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
            Name = name;
            Encoding = encoding;
        }

        public string Format()
            => $"{Name} := {Encoding.Format()}";
    }
}