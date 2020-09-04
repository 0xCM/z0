//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static Konst;

    /// <summary>
    /// Embodies an asynchronous thread of execution that is assigned to a specific CPU core
    /// </summary>
    public class CpuWorker<T>
    {
        public readonly uint CoreNumber;

        public readonly TimeSpan Frequency;

        public readonly ulong? MaxCycles;

        readonly Func<T,T> Worker;

        ulong CycleCount;

        ProcessThread WorkerThread;

        T State;

        IContext Context;

        internal CpuWorker(IContext context, uint core, Func<T,T> worker, T data, TimeSpan freq, ulong? maxCycles = null)
        {
            Context = context;
            CoreNumber = core;
            Worker = worker;
            State =data;
            Frequency = freq;
            MaxCycles = maxCycles;
            WorkerThread = null;
            CycleCount = maxCycles ?? 0;
        }

        public ulong CurrentCycle
        {
            [MethodImpl(Inline)]
            get => CycleCount;
        }

        public Duration TotalCpuUsage
        {
            [MethodImpl(Inline)]
            get  => WorkerThread.TotalProcessorTime.Ticks;
        }

        public T CurrentState
        {
            [MethodImpl(Inline)]
            get  => State;
        }

        /// <summary>
        /// Searches for a thread given an OS-assigned id, not the useless clr id
        /// </summary>
        /// <param name="id">The OS thread Id</param>
        [MethodImpl(Inline)]
        static Option<ProcessThread> thread(uint id)
            => CurrentProcess.ProcessThread(id);

        /// <summary>
        /// Executes a single work cycle
        /// </summary>
        [MethodImpl(Inline)]
        void RunCycle()
        {
            var max = MaxCycles ?? 1_000_000ul;
            for(var i=0ul; i<max; i++)
                State = Worker(State);
        }

        async Task RunOnce()
        {
            RunCycle();
            ++CycleCount;
            term.print(FinishedCycle(CurrentCycle, TotalCpuUsage, State, CoreNumber));
            await asyncDelay(Frequency);
        }

        async Task RunForever()
        {
            while(true)
               await RunOnce();
        }

        async Task RunCycles()
        {
            var max = MaxCycles.Value;
            while(CycleCount++ <= max)
                await RunOnce();
        }

        internal async Task Run()
        {
            WorkerThread = thread(CurrentProcess.OsThreadId).ValueOrDefault();
            if(WorkerThread == null)
            {
                term.error("Thread lookup failed. Aborting worker");
                return;
            }

            WorkerThread.IdealProcessor = (int)CoreNumber;

            if(MaxCycles == null)
                await RunForever();
            else
                await RunCycles();
        }

        public void Control()
        {
            Run().Wait();
        }

        static async Task asyncDelay(TimeSpan duration)
            => await Task.Delay(duration);

        public static AppMsg FinishedCycle(ulong cycle, Duration totalCpu, T state, uint? core = null)
        {
            var coreTxt = core != null ? $"core = {core}, " : string.Empty;
            var cycleTxt = $"cycle = {cycle.ToString().PadLeft(5, '0')}, ";
            var cpuTxt = $"cputime = {totalCpu}, ";
            var stateTxt = $"current state = {state}";
            var msgText = $"({coreTxt}{cycleTxt}{cpuTxt}{stateTxt}";
            return AppMsg.colorize(msgText, FlairKind.Running);
        }
    }
}