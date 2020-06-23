//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{    
    public interface IBinaryBitwiseOpExpr<T> : IBinaryOpExpr<IExpr<T>>, IOperatorExpr<T,BinaryLogicKind>
        where T : unmanaged
    {
    }



}