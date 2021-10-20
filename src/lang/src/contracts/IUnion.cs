//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IUnion : IExpr
    {
        /// <summary>
        /// The number of terms in the union
        /// </summary>
        uint N {get;}
    }

    /// <summary>
    /// Characterizes a (possibly empty) sequence of choices
    /// </summary>
    /// <typeparam name="T">The choice type</typeparam>
    public interface IUnion<T> : IUnion
    {
        /// <summary>
        /// Specifies the possibilities
        /// </summary>
        Span<T> Terms {get;}

        uint IUnion.N
            => (uint)Terms.Length;
    }
}