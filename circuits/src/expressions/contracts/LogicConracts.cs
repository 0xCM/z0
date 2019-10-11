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

    public interface ILogicExpr : IExpr
    {

    }


    public interface ILogicLiteralExpr : ILogicExpr, ILiteralExpr<Bit>
    {

    }

    public interface ILogicOpExpr : ILogicExpr
    {
        /// <summary>
        /// The operator
        /// </summary>
        LogicOpKind Operator {get;}

    }

    public interface ILogicVarExpr : ILogicExpr, IVariableExpr<ILogicExpr>
    {

    }

    public interface IVariedLogicExpr : ILogicExpr, IVariedExpr<ILogicExpr,ILogicVarExpr>
    {

    }

    public interface IVariedLogicExpr<N> : ILogicExpr, IVariedExpr<N,ILogicExpr,ILogicVarExpr>
        where N : ITypeNat, new()
    {

    }

    public interface IUnaryLogicExpr : ILogicOpExpr
    {
        /// <summary>
        /// The operand
        /// </summary>
        ILogicExpr Operand {get;}
    }


    public interface IBinaryLogicExpr : ILogicOpExpr
    {

        /// <summary>
        /// The left operand
        /// </summary>
        ILogicExpr Left {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        ILogicExpr Right {get;}


    }

    public interface ITernaryLogicExpr : ILogicOpExpr
    {

        /// <summary>
        /// The first operand
        /// </summary>
        ILogicExpr First {get;}

        /// <summary>
        /// The second operand
        /// </summary>
        ILogicExpr Second {get;}

        /// <summary>
        /// The third operand
        /// </summary>
        ILogicExpr Third {get;}
    }
}