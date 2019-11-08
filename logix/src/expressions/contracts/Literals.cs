//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

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

    public interface ILiteralSeq<T> : ILiteralExpr, ISeqExpr<T>
        where T : unmanaged
    {


    }

    public interface ILiteralLogicSeq : ILiteralSeq<bit>, ILogicExpr
    {

    }
    
    public interface ILogicLiteral : ILogicExpr, ILiteralExpr
    {
        bit Value {get;}
    }

    public interface ILogicLiteral<T> : ILogicLiteral, ILogicExpr<T>
        where T : unmanaged
    {

    }


}