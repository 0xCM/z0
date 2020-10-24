//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Threading.Tasks;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Returns after specified duration has elapsed
        /// </summary>
        /// <param name="duration">The time to wait before returning</param>
        [MethodImpl(Inline)]
        public static void delay(TimeSpan duration)
            => Task.Delay(duration).RunSynchronously();

        /// <summary>
        /// Introduces an asynchronous delay
        /// </summary>
        /// <param name="duration">The length of the delay to introduce</param>
        public static async Task delayAsync(TimeSpan duration)
            => await Task.Delay(duration);
    }
}