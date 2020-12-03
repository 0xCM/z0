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
    /// Characterizes a uniform distribution
    /// </summary>
    /// <typeparam name="T">The sample value type</typeparam>
    /// <remarks>See https://en.wikipedia.org/wiki/Uniform_distribution</remarks>
    public readonly struct UniformSpec<T> : IDistributionSpec<UniformSpec<T>,T>
        where T : unmanaged
    {
        /// <summary>
        /// The lower bound
        /// </summary>
        public readonly T Min;

        /// <summary>
        /// The upper bound
        /// </summary>
        public readonly T Max;

        /// <summary>
        /// Defines a unform distribution bound between lower and upper bounds
        /// </summary>
        /// <param name="min">The lower bound</param>
        /// <param name="max">The upper bound</param>
        [MethodImpl(Inline)]
        public static UniformSpec<T> Define(T min, T max)
            => new UniformSpec<T>(min,max);

        /// <summary>
        /// Defines a uniform distribution bound to an interval domain
        /// </summary>
        /// <param name="domain">The potential range of sample values</param>
        /// <typeparam name="T">The sample element type</typeparam>
        [MethodImpl(Inline)]
        public static UniformSpec<T> Define(in Interval<T> src)
            => new UniformSpec<T>(src.Left,src.Right);

        [MethodImpl(Inline)]
        public static implicit operator (T min, T max)(in UniformSpec<T> spec)
            => (spec.Min, spec.Max);

        [MethodImpl(Inline)]
        public static implicit operator UniformSpec<T>((T min, T max) x )
            => Define(x.min, x.max);

        [MethodImpl(Inline)]
        public static implicit operator UniformSpec<T>(in Interval<T> x)
            => Define(x.Left, x.Right);

        [MethodImpl(Inline)]
        public static implicit operator Interval<T>(in UniformSpec<T> x)
            => Define(x.Min, x.Max);

        [MethodImpl(Inline)]
        public UniformSpec(T min, T max)
        {
            Min = min;
            Max = max;
        }

        /// <summary>
        /// Classifies the distribution
        /// </summary>
        public DistributionKind DistKind
            => DistributionKind.Uniform;

        [MethodImpl(Inline)]
        public UniformSpec<int> ToInt32()
            => new UniformSpec<int>(NumericCast.force<T,int>(Min), NumericCast.force<T,int>(Max));

        [MethodImpl(Inline)]
        public UniformSpec<float> ToFloat32()
            => new UniformSpec<float>(NumericCast.force<T,float>(Min), NumericCast.force<T,float>(Max));

        [MethodImpl(Inline)]
        public UniformSpec<double> ToFloat64()
            => new UniformSpec<double>(NumericCast.force<T,double>(Min), NumericCast.force<T,double>(Max));
   }
}