//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
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
            Name = name;
            Encoding = encoding;
        }

        public string Format()
            => $"{Name} := {Encoding.Format()}";
    }
}