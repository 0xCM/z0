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

    public interface IBitExpr : IExpr
    {
        
    }

    public interface IBitExpr<T> : IBitExpr
        where T : unmanaged
    {

    }

    public interface IBitVarExpr<T> : IBitExpr<T>, IVariableExpr<IBitExpr<T>>
        where T : unmanaged
    {

    }

    public interface IBitOpExpr : IBitExpr
    {
        /// <summary>
        /// The operator
        /// </summary>
        BitOpKind Operator {get;}

    }

    public interface IBitOpExpr<T> : IBitExpr<T>, IBitOpExpr
        where T : unmanaged
    {

    }

    public interface IBitLiteralExpr<T> : ILiteralExpr<T>,  IBitExpr<T>
        where T : unmanaged
    {
    }

    public interface IUnaryBitwiseExpr<T> : IBitOpExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The left operand
        /// </summary>
        IBitExpr<T> Operand {get;}

    }

    public interface IBinaryBitwiseExpr<T> : IBitOpExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The left operand
        /// </summary>
        IBitExpr<T> Left {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        IBitExpr<T> Right {get;}
    }

    public interface IMixedBitwiseExpr<T> : IBitOpExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The left operand
        /// </summary>
        IBitExpr<T> Left {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        IBitExpr<uint> Right {get;}
    }

    public interface ITernaryBitwiseExpr<T> : IBitOpExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The first operand
        /// </summary>
        IBitExpr<T> First {get;}

        /// <summary>
        /// The second operand
        /// </summary>
        IBitExpr<T> Second {get;}

        /// <summary>
        /// The third operand
        /// </summary>
        IBitExpr<T> Third {get;}

    }



}