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

    public interface IArithmeticOp<T> : IArithmeticOp, IArithmeticExpr<T>, ITypedOpExpr<T>
        where T : unmanaged
    {


    }

    public interface IArithmeticOp<T,K> : IArithmeticOp<T>, ITypedOpExpr<T,K>
        where T : unmanaged
        where K : Enum
    {


    }
 
    public interface IUnaryArithmeticOp :  IArithmeticOp
    {

    }


    public interface IUnaryArithmeticOp<T> :  IUnaryArithmeticOp, IArithmeticOp<T>, ITypedUnaryOp<T, UnaryArithmeticOpKind> 
        where T : unmanaged
    {

    }

    public interface IBinaryArithmeticOp :  IArithmeticOp
    {

    }

    public interface IBinaryArithmeticOp<T> :  IBinaryArithmeticOp,  IArithmeticOp<T,BinaryArithmeticOpKind>
        where T : unmanaged
    {
        ITypedExpr<T> LeftArg {get;}

        ITypedExpr<T> RightArg {get;}


    }

    public interface IComparisonExpr : IArithmeticOp
    {

    }

    /// <summary>
    /// Characterizes a comparson expression over a parametric type
    /// </summary>
    /// <typeparam name="T">The type over which the comparison is defined</typeparam>
    public interface IComparisonExpr<T> : IComparisonExpr, IArithmeticOp<T,ComparisonOpKind>
        where T : unmanaged
    {

        ITypedExpr<T> LeftArg {get;}

        ITypedExpr<T> RightArg {get;}
    }

}