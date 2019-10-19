//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public interface IShiftOp : IOpExpr
    {
        
    }

    public interface IShiftOp<T> : IShiftOp, IOpExpr<T, ShiftOpKind>
        where T : unmanaged
    {
        /// <summary>
        /// The thing to shift
        /// </summary>
        IExpr<T> Subject {get;}


        IExpr<int> Offset {get;}
    }

}