//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;

    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    /// <summary>
    /// Characterizes a formula which, by definition, is a named expression
    /// </summary>
    public interface IFormula : IExpr
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
    public interface IFormula<T> : IFormula
        where T : unmanaged
    {
        /// <summary>
        /// The defining expression
        /// </summary>
        new ITypedExpr<T> Encoding {get;}
    }
}