//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    public interface IUnaryBitwiseOpExpr<T> : IUnaryOpExpr<IExpr<T>>, IOperatorExpr<T, UnaryBitLogicKind>
        where T : unmanaged
    {

    }


}