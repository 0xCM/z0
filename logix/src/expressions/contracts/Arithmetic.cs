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

    public interface IArithmeticExpr : IExpr
    {

    }
    
    public interface IArithmeticExpr<T> : IArithmeticExpr, ITypedExpr<T>
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

    public interface IArithmeticOp<T,K> : IArithmeticOp<T>, IOpExpr<T,K>
        where T : unmanaged
        where K : Enum
    {


    }
 
    public interface IUnaryArithmeticOp :  IArithmeticOp
    {

    }

    public interface IComparisonExpr : IArithmeticOp
    {

    }

    public interface IComparisonExpr<T> : IComparisonExpr, IArithmeticOp<T,ComparisonOpKind>
        where T : unmanaged
    {
        IArithmeticExpr<T> LeftArg {get;}

        IArithmeticExpr<T> RightArg {get;}
    }


    public interface IUnaryArithmeticOp<T> :  IUnaryArithmeticOp,  IArithmeticOp<T,UnaryArithmeticOpKind>
        where T : unmanaged
    {
        /// <summary>
        /// The one and only operand
        /// </summary>
        ITypedExpr<T> Operand {get;}

    }

}