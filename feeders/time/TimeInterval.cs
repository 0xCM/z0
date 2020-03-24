//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents the content of a contiguous interval between comparable lower and upper bounds of the same type
    /// </summary>
    public interface ITimeInterval 
    {
        /// <summary>
        /// The first endpoint
        /// </summary>
        object Min { get; }

        /// <summary>
        /// The second endpoint
        /// </summary>
        object Max { get; }

        /// <summary>
        /// Specifies whether the left endpoint is included in the interval
        /// </summary>
        bool LeftInclusive { get; }

        /// <summary>
        /// Specifies whether the right endpoint is included in the interval
        /// </summary>
        bool RightInclusive { get; }
    }

    public interface ITimeInterval<out T> : ITimeInterval
    {
        /// <summary>
        /// The inclusive lower bound
        /// </summary>
        new T Min { get; }

        /// <summary>
        /// The inclusive upper bound
        /// </summary>
        new T Max { get; }
    }

    /// <summary>
    /// Defines inclusive lower and upper bounds for a comparable set of values
    /// </summary>
    /// <typeparam name="T">The element type</typeparam>
    public readonly struct TimeInterval<T> : ITimeInterval<T>
        where T : IComparable
    {
        public TimeInterval(T Min, T Max)
        {
            this.Min = Min;
            this.Max = Max;
        }

        /// <summary>
        /// The minimum value in the range
        /// </summary>
        public T Min { get; }

        /// <summary>
        /// The maximum value in the range
        /// </summary>
        public T Max { get; }

        bool ITimeInterval.LeftInclusive
            => true;

        bool ITimeInterval.RightInclusive
            => true;

        object ITimeInterval.Min
            => Min;

        object ITimeInterval.Max
            => Max;

        /// <summary>
        /// Tests whether a value is in the range
        /// </summary>
        /// <param name="candidate">The value to test</param>
        public bool In(T candidate)
            => candidate.CompareTo(Min) >= 0  && candidate.CompareTo(Max) <= 0;

        public override string ToString()
            => $"[{Min}, {Max}]";
    }
}