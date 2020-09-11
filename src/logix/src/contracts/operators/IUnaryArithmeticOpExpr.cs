//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;

    public interface IUnaryArithmeticOpExpr :  IArithmeticOpExpr
    {

    }


    public interface IUnaryArithmeticOpExpr<T> :  IUnaryArithmeticOpExpr, IArithmeticOpExpr<T, UnaryArithmeticOpId>
        where T : unmanaged
    {

    }
}