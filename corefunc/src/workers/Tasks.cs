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

    using static Root;

    /// <summary>
    /// Defines a task api for common operations
    /// </summary>
    public static class Tasks
    {
        /// <summary>
        /// Executes a worker that computes a value within the context of a new task
        /// </summary>
        /// <param name="worker">The worker to execute</param>
        [MethodImpl(Inline)]   
        public static Task<T> create<T>(Func<T> worker)
            => Task.Factory.StartNew(worker);

        /// <summary>
        /// Executes a worker within the context of a new task
        /// </summary>
        /// <param name="worker">The worker to execute</param>
        [MethodImpl(Inline)]   
        public static Task create(Action worker)
            => Task.Factory.StartNew(worker);

        /// <summary>
        /// Executes a worker that computes a value within the context of a new task
        /// </summary>
        /// <param name="worker">The worker to execute</param>
        /// <param name="s0">The value to supply to the worker</param>
        [MethodImpl(Inline)]   
        public static Task<T> create<S,T>(Func<S,T> worker, S s0)
            => Task.Factory.StartNew(o => worker((S)o), s0);

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
        public static async Task asyncDelay(TimeSpan duration)
            => await Task.Delay(duration);
    }
}