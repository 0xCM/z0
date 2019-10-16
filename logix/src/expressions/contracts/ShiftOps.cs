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

    public interface IShiftOp<T> : IOpExpr<T, ShiftOpKind>
        where T : unmanaged
    {
        /// <summary>
        /// The thing to shift
        /// </summary>
        IExpr<T> Subject {get;}

        /// <summary>
        /// The amount to shift
        /// </summary>
        IExpr<int> Offset {get;}
    }

}