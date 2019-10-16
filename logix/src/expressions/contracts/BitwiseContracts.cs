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

    public interface IBitLitExpr<T> : ILiteralExpr<T>,  IBitExpr<T>
        where T : unmanaged
    {
    }

    public interface IUnaryBitExpr<T> : IBitOpExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The one and only operand
        /// </summary>
        IBitExpr<T> Subject {get;}

    }

    public interface IBinaryBitExpr<T> : IBitOpExpr<T>
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


    public interface ITernaryBitExpr<T> : IBitOpExpr<T>
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

    public interface IBitShiftExpr<T> : IBitOpExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The thing to shift
        /// </summary>
        IBitExpr<T> Subject {get;}

        /// <summary>
        /// The amount to shift
        /// </summary>
        IBitExpr<int> Offset {get;}
    }


}