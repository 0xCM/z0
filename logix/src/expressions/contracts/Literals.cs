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

    public interface ILiteralExpr : IExpr
    {
        
    }

    public interface ILiteralExpr<T> : ILiteralExpr, IExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The value of the literal
        /// </summary>
        T Value {get;}                
    }

    public interface IBitLiteralExpr : ILogicExpr, ILiteralExpr<bit>
    {

    }

    public interface IBitLiteralSeq
    {
        /// <summary>
        /// The sequence terms
        /// </summary>
        bit[] Terms {get;}

        /// <summary>
        /// Sequence term accessor/manipulator
        /// </summary>
        bit this[int index] {get;set;}

        /// <summary>
        /// The number of terms in the sequence
        /// </summary>
        int Length {get;}
    }
}