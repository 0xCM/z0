//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;

    public interface IShiftOp : IOperator
    {
        
    }

    public interface IShiftOp<T> : IShiftOp, IOperator<T, ShiftOpKind>
        where T : unmanaged
    {
        /// <summary>
        /// The thing to shift
        /// </summary>
        IExpr<T> Subject {get;}


        IExpr<byte> Offset {get;}
    }
}