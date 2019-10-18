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

    public interface IArithmeticExpr : IExpr
    {

    }
    
    public interface IArithmeticExpr<T> : IArithmeticExpr, IExpr<T>
        where  T : unmanaged
    {
        
    }

    public interface IArithmeticOp : IOpExpr
    {

    }

    public interface IArithmeticOp<T> : IArithmeticOp, IArithmeticExpr<T>, IOpExpr<T>
        where T : unmanaged
    {


    }

    public interface IArithmeticOp<T,E> : IArithmeticOp<T>, IOpExpr<T,E>
        where T : unmanaged
        where E : Enum
    {


    }

    public interface IUnaryArithmeticOp :  IArithmeticOp
    {

    }

    public interface IUnaryArithmeticOp<T> :  IUnaryArithmeticOp,  IUnaryOp<T>, IArithmeticOp<T,UnaryArithmeticOpKind>
        where T : unmanaged
    {
        /// <summary>
        /// The one and only operand
        /// </summary>
        IExpr<T> Operand {get;}

    }

}