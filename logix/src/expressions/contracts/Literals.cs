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

    public interface ITypedLiteral<T> : ILiteralExpr, ITypedExpr<T>
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





}