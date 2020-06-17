//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines operations specific to uniform distributions
    /// </summary>
    [ApiHost]
    public readonly struct UniformSpec
    {
        /// <summary>
        /// Interprets a supplied spec as a uniform spec; an error
        /// is raised if the spec does not define a uniform distribution
        /// </summary>
        /// <param name="spec">The distribution specifier</param>
        /// <typeparam name="T">The sample element type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static UniformSpec<T> from<T>(IDistributionSpec<T> spec)
            where T : unmanaged
                => (UniformSpec<T>)spec;

        /// <summary>
        /// Defines a unform distribution bound between lower and upper bounds
        /// </summary>
        /// <param name="min">The lower bound</param>
        /// <param name="max">The upper bound</param>
        /// <typeparam name="T">The sample element type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static UniformSpec<T> define<T>(T min, T max)
            where T : unmanaged
                => UniformSpec<T>.Define(min,max);        

        /// <summary>
        /// Defines a uniform distribution bound to an interval domain
        /// </summary>
        /// <param name="domain">The potential range of sample values</param>
        /// <typeparam name="T">The sample element type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static UniformSpec<T> define<T>(in Interval<T> domain)
            where T : unmanaged
                => UniformSpec<T>.Define(domain);                
    }
}