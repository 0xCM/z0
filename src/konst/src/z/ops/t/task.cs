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
        /// Executes a worker that computes a value within the context of a new task
        /// </summary>
        /// <param name="worker">The worker to execute</param>
        [MethodImpl(Inline)]
        public static Task<T> task<T>(Func<T> worker)
            => Task.Factory.StartNew(worker);

        /// <summary>
        /// Executes a worker within the context of a new task
        /// </summary>
        /// <param name="worker">The worker to execute</param>
        [MethodImpl(Inline)]
        public static Task task(Action worker)
            => Task.Factory.StartNew(worker);

        /// <summary>
        /// Executes a worker that computes a value within the context of a new task
        /// </summary>
        /// <param name="worker">The worker to execute</param>
        /// <param name="s0">The value to supply to the worker</param>
        [MethodImpl(Inline)]
        public static Task<T> task<S,T>(Func<S,T> worker, S s0)
            => Task.Factory.StartNew(o => worker((S)o), s0);
    }
}