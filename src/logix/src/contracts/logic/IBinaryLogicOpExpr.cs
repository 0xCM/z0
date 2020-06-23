//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{    
    public interface IBinaryLogicOpExpr : IBinaryOpExpr<ILogicExpr>, ILogicOpExpr<BinaryLogicKind>
    {

    }

    public interface IBinaryLogicOpExpr<T> : IBinaryLogicOpExpr, IBinaryOpExpr<ILogicExpr<T>>,  ILogicOpExpr<T,BinaryLogicKind>
        where T : unmanaged
    {

    }

}