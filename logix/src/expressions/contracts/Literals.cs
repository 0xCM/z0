//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    public interface ILiteralExpr : IExpr
    {
        
    }

    public interface ILiteralExpr<T> : ILiteralExpr, IExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The value of the literal
        /// </summary>
        T Value {get;}                
    }

    public interface ILiteralSeqExpr<T> : ILiteralExpr, ISeqExpr<T>
        where T : unmanaged
    {

    }

    public interface ILiteralLogicSeqExpr : ILiteralSeqExpr<bit>, ILogicExpr
    {

    }
    
    public interface ILogicLiteralExpr : ILogicExpr, ILiteralExpr
    {
        bit Value {get;}
    }

    public interface ILogicLiteralExpr<T> : ILogicLiteralExpr, ILogicExpr<T>
        where T : unmanaged
    {

    }
}