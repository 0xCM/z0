//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;    

    /// <summary>
    /// Characterizes a formula which, by definition, is a named expression
    /// </summary>
    public interface IFormulaExpr : IExpr
    {
        /// <summary>
        /// The formula name, unique with respect to some context
        /// </summary>
        string Name {get;}

        /// <summary>
        /// The defining expression
        /// </summary>
        IExpr Encoding {get;}
    }

    /// <summary>
    /// Characterizes a typed formula, a named typed expression
    /// </summary>
    public interface IFormulaExpr<T> : IFormulaExpr
        where T : unmanaged
    {
        /// <summary>
        /// The defining expression
        /// </summary>
        new IExpr<T> Encoding {get;}

        IExpr IFormulaExpr.Encoding => Encoding;
    }
}