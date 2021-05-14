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

    partial struct root
    {
        /// <summary>
        /// Runs a task that executes a specified worker
        /// </summary>
        /// <param name="worker">The worker to execute</param>
        [MethodImpl(Inline), Op]
        public static Task run(Action worker)
            => Task.Run(worker);

        /// <summary>
        /// Runs a task that executes a specified worker
        /// </summary>
        /// <param name="worker">The worker to execute</param>
        [MethodImpl(Inline), Op]
        public static Task run(Action worker, CancellationToken ct)
            => Task.Run(worker, ct);

        /// <summary>
        /// Runs a task that computes a result
        /// </summary>
        /// <param name="f">The emitter</param>
        [MethodImpl(Inline)]
        public static Task<T> run<T>(Func<T> f)
            => Task.Run(f);

        /// <summary>
        /// Runs a task that computes a transformation
        /// </summary>
        /// <param name="f">The transformer</param>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Task<T> run<S,T>(Func<S,T> f, S s0)
            => Task.Factory.StartNew(o => f((S)o), s0);

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
        [MethodImpl(Inline), Op]
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