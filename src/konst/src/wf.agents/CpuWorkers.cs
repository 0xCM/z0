//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;
    using System.Diagnostics;

    using static Konst;

    [ApiHost]
    public readonly struct CpuWorkers
    {
        public const ulong DefaultCycleCount = ulong.MaxValue;

        public const ulong DefaultCycleLength = Pow2.T16;

        public const ulong DefaultStatusFrequency = Pow2.T12;

        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref CpuCycleInfo describe<T>(in CpuWorker<T> src, ref CpuCycleInfo dst)
        {
            dst = default;
            dst.WorkerId = src.WorkerId;
            dst.CpuCore = src.CpuCore;
            dst.MaxCycles = src.MaxCycles;
            dst.CompletedCycles = src.CurrentCycle;
            dst.CpuUsage = src.CpuUsage;
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string format(in CpuCycleInfo src)
        {
            const string Pattern = "worker: {0,-3} | cpu.core:{1,-3} | cycles.max:0x{2,-10:x} | cycles.completed:0x{3,-10:x} | cpu.usage:0x{4,-10:x}";
            return string.Format(Pattern, src.WorkerId, src.CpuCore, src.MaxCycles, src.CompletedCycles, src.CpuUsage);
        }

        /// <summary>
        /// Searches for a thread given an OS-assigned id
        /// </summary>
        /// <param name="id">The OS thread Id</param>
        [MethodImpl(Inline), Op]
        public static ProcessThread thread(uint id)
            => CurrentProcess.ProcessThread(id);

        [MethodImpl(Inline), Op]
        public static async Task delay(TimeSpan duration)
            => await Task.Delay(duration);

        static int WorkerId = 0;

        [MethodImpl(Inline), Op]
        static int advance()
            => Interlocked.Increment(ref WorkerId);

        [MethodImpl(Inline), Op]
        public static ulong identify(uint core, uint seq)
            => (ulong)core | (ulong)seq << 32;

        [MethodImpl(Inline), Op]
        public static string name(uint core, uint worker)
        {
            const string Pattern = "{0}/{1}";
            return string.Format(Pattern,  core, worker);
        }

        public static CpuWorker<S,T> create<S,T>(CpuWorkerSettings spec, Func<S,T> projector, ITableExchange<S,T> exchange)
            where S : struct
            where T : struct
        {
            var worker = new CpuWorker<S,T>();
            worker.Spec = spec;
            worker.Exchange = exchange;
            worker.Projector = projector;
            worker.Continue = true;
            return worker;
        }

        [Op]
        public static CpuWorker<ulong> example(IWfShell wf, uint core = 3, ulong length = DefaultCycleLength,  ulong cycles = DefaultCycleCount)
        {
            static ulong xor(ulong max)
            {
                var result = 1ul;
                for(var i=0ul; i<max; i++)
                    result &= (ulong)i;
                return result;
            }

            return create(wf, core, xor, cycles, new TimeSpan(0,0,0,0,10));
        }

        [MethodImpl(Inline)]
        public static CpuWorker<T> create<T>(IWfShell wf, uint core, Func<T,T> fx, T state, TimeSpan frequency, ulong length = DefaultCycleLength, ulong cycles = DefaultCycleCount)
        {
            var id = (uint)advance();
            return create(wf, core, id, fx, state, frequency, name(core, id), length, cycles);
        }

        /// <summary>
        /// Creates and starts a worker
        /// </summary>
        /// <param name="context">The context conferred to the worker</param>
        /// <param name="cpucore">The CPU core number</param>
        /// <param name="fx">The worker function</param>
        /// <param name="state">The subject input</param>
        /// <param name="frequency">The worker frequency</param>
        /// <param name="cycles">The maximum number of cycles the worker will be allowed to execute before forceful termination</param>
        /// <typeparam name="T">The subject type</typeparam>
        [Op, Closures(Closure)]
        public static CpuWorker<T> create<T>(IWfShell wf, uint core, uint id, Func<T,T> fx, T state, TimeSpan frequency, string name, ulong length = DefaultCycleLength, ulong cycles = DefaultCycleCount)
        {
            var worker = new CpuWorker<T>(wf, core, id, fx, state, frequency, length, cycles);
            var control = new Thread(new ThreadStart(worker.Execute))
            {
                IsBackground = true,
                Name = name
            };
            worker.ManagedWorkerThread = control;
            control.Start();
            return worker;
        }
    }
}