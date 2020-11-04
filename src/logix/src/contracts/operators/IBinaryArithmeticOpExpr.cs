//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;

    public interface IBinaryArithmeticOpExpr :  IArithmeticOpExpr
    {

    }

    public interface IBinaryArithmeticOpExpr<T> : IBinaryArithmeticOpExpr, IArithmeticOpExpr<T,BinaryArithmeticApiClass>
        where T : unmanaged
    {
        IExpr<T> LeftArg {get;}

        IExpr<T> RightArg {get;}
    }
}