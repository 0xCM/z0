//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static memory;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a value emitter that supports placing upper and/or lower bounds on
    /// the values produced
    /// </summary>
    /// <typeparam name="T">The production value type</typeparam>
    [Free]
    public interface IDomainSource<T> : IValueSource<T>
        where T : unmanaged
    {
        /// <summary>
        /// Retrieves the next point from the source, constrained by an upper bound
        /// </summary>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The point type</typeparam>
        T Next(T max);

        /// <summary>
        /// Retrieves the next point from the source, constrained by upper and lower bounds
        /// </summary>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive max value</param>
        T Next(T min, T max);

        /// <summary>
        /// Fills the span, from stem-to-stern with <typeparamref name='T'/> cells from the reifying source constrained to a specified domain
        /// </summary>
        /// <param name="domain">The source domain</param>
        /// <param name="dst">The target spen</param>
        void Fill(ClosedInterval<T> domain, Span<T> dst)
        {
            var count = dst.Length;
            if(count != 0)
            {
                ref var target = ref first(dst);
                for(var i=0; i<count; i++)
                    seek(target,i) = Next(domain.Min, domain.Max);
            }
        }
    }

    /// <summary>
    /// Characterizes a source that emits parametric value constrained to a specified domain
    /// </summary>
    [Free]
    public interface IDomainSource : ISource
    {
        /// <summary>
        /// Retrieves the next point from the source, constrained by an upper bounds
        /// </summary>
        /// <param name="max">The exclusive max value</param>
        /// <typeparam name="T">The point type</typeparam>
        T Next<T>(T max)
            where T : unmanaged;

        /// <summary>
        /// Retrieves the next point from the source, constrained by upper and lower bounds
        /// </summary>
        /// <param name="min">The inclusive min value</param>
        /// <param name="max">The exclusive max value</param>
        /// <typeparam name="T">The point type</typeparam>
        T Next<T>(T min, T max)
            where T : unmanaged;

        /// <summary>
        /// Retrieves the next point from the source, bound within a specified interval
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <typeparam name="T">The point type</typeparam>
        T Next<T>(Interval<T> domain)
            where T : unmanaged
                => Next(domain.Left, domain.Right);

        /// <summary>
        /// Retrieves the next point from the source, bound within a specified interval
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <typeparam name="T">The point type</typeparam>
        T Next<T>(ClosedInterval<T> domain)
            where T : unmanaged
                => Next(domain.Min, domain.Max);
    }
}