//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a source that populates a <see cref='Span{T}'/>
    /// </summary>
    /// <typeparam name="T">The span cell type</typeparam>
    [Free]
    public interface ISpanSource<T>
    {
        /// <summary>
        /// Fills the span, from stem-to-stern with <typeparamref name='T'/> cells from the reifying source
        /// </summary>
        /// <param name="dst">The target spen</param>
        void Fill(Span<T> dst);
    }


    [Free]
    public interface ISpanValueSource
    {
        void Fill<T>(Span<T> dst)
            where T : struct;
    }

    /// <summary>
    /// Characterizes a source that populates a <see cref='Span{T}'/> with structural <typeparamref name='T'/> values
    /// </summary>
    /// <typeparam name="T">The span cell type</typeparam>
    [Free]
    public interface ISpanValueSource<T> : ISpanSource<T>
        where T : struct
    {
    }

    /// <summary>
    /// Characterizes a source that populates a <see cref='Span{T}'/> with unmanaged <typeparamref name='T'/> values constrained to a specified domain
    /// </summary>
    /// <typeparam name="T">The span cell type</typeparam>
    [Free]
    public interface ISpanDomainSource<T> : ISpanValueSource<T>, IDomainSource<T>
        where T : unmanaged
    {
        /// <summary>
        /// Fills the span, from stem-to-stern with <typeparamref name='T'/> cells from the reifying source constrained to a specified domain
        /// </summary>
        /// <param name="domain">The source domain</param>
        /// <param name="dst">The target spen</param>
        void Fill(ClosedInterval<T> domain, Span<T> dst);

        void ISpanSource<T>.Fill(Span<T> dst)
            => Fill(ClosedInterval<T>.Full, dst);
    }
}