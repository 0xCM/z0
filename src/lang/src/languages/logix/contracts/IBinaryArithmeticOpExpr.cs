//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IBinaryArithmeticOpExpr :  IArithmeticOpExpr
    {

    }

    public interface IBinaryArithmeticOpExpr<T> : IBinaryArithmeticOpExpr, IArithmeticOpExpr<T,ApiBinaryArithmeticClass>
        where T : unmanaged
    {
        IExpr<T> LeftArg {get;}

        IExpr<T> RightArg {get;}
    }
}