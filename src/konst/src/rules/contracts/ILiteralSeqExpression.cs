//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ILiteralSeqExpr<T> : ILiteralExpr, ISeqExpr<T>
        where T : unmanaged
    {

    }
}