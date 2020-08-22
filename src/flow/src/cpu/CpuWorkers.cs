//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading;

    public static class CpuWorkers
    {
        /// <summary>
        /// Creates and starts a worker
        /// </summary>
        /// <param name="context">The context conferred to the worker</param>
        /// <param name="cpucore">The CPU core number</param>
        /// <param name="worker">The worker function</param>
        /// <param name="state">The subject input</param>
        /// <param name="frequency">The worker frequency</param>
        /// <param name="MaxCycles">The maximum number of cycles the worker will be allowed to execute before forceful termination</param>
        /// <typeparam name="T">The subject type</typeparam>
        public static CpuWorker<T> start<T>(IContext context, uint cpucore, Func<T,T> worker, T state, TimeSpan frequency, ulong? MaxCycles = null)
        {
            var cpuWorker = new CpuWorker<T>(context, cpucore, worker, state, frequency, MaxCycles);
            var workerThread = new Thread(new ThreadStart(cpuWorker.Control))
            {
                IsBackground = true,
                Name = WorkerName(cpucore)
            };

            workerThread.Start();
            return cpuWorker;
        }

        static int WorkerId;

        static string WorkerName(uint cpucore)
            => $"{Interlocked.Increment(ref WorkerId)}/{cpucore}";

        static CpuWorker<ulong> Example(IContext context)
        {
            ulong Sum(ulong max)
            {
                var sum = 0ul;
                for(var i=0; i<(int)max; i++)
                    sum += (ulong)i;
                return sum;
            }

            return start(context, 1, Sum, (ulong)Pow2.T20, new TimeSpan(0,0,1));
        }
    }
}