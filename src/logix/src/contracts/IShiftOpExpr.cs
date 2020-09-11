//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    public interface IShiftOpExpr : IOperatorExpr
    {

    }

    public interface IShiftOpExpr<T> : IShiftOpExpr, IOperatorExpr<T, BitShiftOpId>
        where T : unmanaged
    {
        /// <summary>
        /// The thing to shift
        /// </summary>
        IExpr<T> Subject {get;}


        IExpr<byte> Offset {get;}
    }
}