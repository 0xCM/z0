//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
    
    public interface IArithmeticExpr<T> : IArithmeticExpr, IExpr<T>
        where  T : unmanaged
    {
        
    }

    public interface IArithmeticOp : IOperator
    {

    }

    public interface IArithmeticOp<T> : IArithmeticOp, IArithmeticExpr<T>, IOperator<T>
        where T : unmanaged
    {


    }

    public interface IArithmeticOp<T,K> : IArithmeticOp<T>, IOperator<T,K>
        where T : unmanaged
        where K : unmanaged, Enum
    {


    }
 
    public interface IUnaryArithmeticOp :  IArithmeticOp
    {

    }


    public interface IUnaryArithmeticOp<T> :  IUnaryArithmeticOp, IArithmeticOp<T, UnaryArithmeticOpKind>
        where T : unmanaged
    {

    }

    public interface IBinaryArithmeticOp :  IArithmeticOp
    {

    }

    public interface IBinaryArithmeticOp<T> : IBinaryArithmeticOp, IArithmeticOp<T,BinaryArithmeticOpKind>
        where T : unmanaged
    {
        IExpr<T> LeftArg {get;}

        IExpr<T> RightArg {get;}

    }

}