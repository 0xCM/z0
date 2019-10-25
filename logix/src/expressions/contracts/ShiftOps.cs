//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public interface IShiftOp : IOpExpr
    {
        
    }

    public interface IShiftOp<T> : IShiftOp, ITypedOpExpr<T, ShiftOpKind>
        where T : unmanaged
    {
        /// <summary>
        /// The thing to shift
        /// </summary>
        ITypedExpr<T> Subject {get;}


        ITypedExpr<int> Offset {get;}
    }

}