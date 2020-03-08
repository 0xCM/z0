//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    public interface IArithmeticExpr : IExpr
    {

    }
    
    public interface IArithmeticExpr<T> : IArithmeticExpr, IExpr<T>
        where  T : unmanaged
    {
        
    }

    public interface IArithmeticOpExpr : IOperatorExpr
    {

    }

    public interface IArithmeticOpExpr<T> : IArithmeticOpExpr, IArithmeticExpr<T>, IOperatorExpr<T>
        where T : unmanaged
    {


    }

    public interface IArithmeticOpExpr<T,K> : IArithmeticOpExpr<T>, IOperatorExpr<T,K>
        where T : unmanaged
        where K : unmanaged, Enum
    {


    }
    
    public interface IUnaryArithmeticOpExpr :  IArithmeticOpExpr
    {

    }
    

    public interface IUnaryArithmeticOpExpr<T> :  IUnaryArithmeticOpExpr, IArithmeticOpExpr<T, UnaryArithmeticKind>
        where T : unmanaged
    {

    }

    public interface IBinaryArithmeticOpExpr :  IArithmeticOpExpr
    {

    }

    public interface IBinaryArithmeticOpExpr<T> : IBinaryArithmeticOpExpr, IArithmeticOpExpr<T,BinaryArithmeticKind>
        where T : unmanaged
    {
        IExpr<T> LeftArg {get;}

        IExpr<T> RightArg {get;}
    }
}