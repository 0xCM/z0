//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System.Collections.Generic;

    public interface ISeqExpr : IExpr
    {

    }
    
    public interface ILazySeqExpr<T> : ISeqExpr
        where T : unmanaged
    {
        /// <summary>
        /// The terms in the sequence that are evaluated on-demand
        /// </summary>
        IEnumerable<T> Terms {get;}   

        int? Length{get;}
    }

    /// <summary>
    /// Characterizes a finite sequence of terms
    /// </summary>
    /// <typeparam name="T">The term type</typeparam>
    public interface ISeqExpr<T> : ISeqExpr
        where T : unmanaged
    {
        /// <summary>
        /// The terms in the sequence
        /// </summary>
        T[] Terms {get;}

        /// <summary>
        /// Sequence value accessor/manipulator
        /// </summary>
        T this[int index] {get;set;}

        /// <summary>
        /// The number of terms in the sequence
        /// </summary>
        int Length {get;}
    }
}