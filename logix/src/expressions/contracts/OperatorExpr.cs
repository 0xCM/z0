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
    /// Characterizes an expression defined via an operator
    /// </summary>
    public interface IOpExpr : IExpr
    {
        
    }

    /// <summary>
    /// Characterizes parametric defined via an operator
    /// </summary>
    public interface IOpExpr<X> : IOpExpr
        where X : IExpr
    {

    }

    public interface ILogicOpExpr : ILogicExpr, IOpExpr
    {

    }

    /// <summary>
    /// Characterizes a typed expression defined via an operator
    /// </summary>
    /// <typeparam name="T">The type over which the expression is defined</typeparam>
    public interface ITypedOpExpr<T> : ITypedExpr<T>, IOpExpr
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a typed expression defined via an operator of specified kind
    /// </summary>
    /// <typeparam name="T">The type over which the expression is defined</typeparam>
    /// <typeparam name="K">The operator classifier</typeparam>
    public interface ITypedOpExpr<T,K> : ITypedOpExpr<T>
        where T : unmanaged
        where K : Enum
    {
        /// <summary>
        /// Specifies the class to which the operator belongs
        /// </summary>
        K OpKind {get;}
    }

    public interface ILogicOpExpr<K> : ILogicOpExpr, IOpExpr
        where K : Enum
    {
        /// <summary>
        /// Specifies the class to which the operator belongs
        /// </summary>
        K OpKind {get;}
    }


}