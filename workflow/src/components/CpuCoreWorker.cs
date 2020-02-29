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

    using static Root;

    /// <summary>
    /// Embodies an asynchrounous thread of execution that is assigned to a specific CPU core
    /// </summary>
    public class CpuCoreWorker<T>
    {        
        internal CpuCoreWorker(IRngContext Context, uint CoreNumber, Func<T,T> Worker, T Data, TimeSpan Frequency, ulong? MaxCycles = null)
        {
            this.Context = Context;
            this.CoreNumber = CoreNumber;
            this.Worker = Worker;
            this.State =Data;
            this.Frequency = Frequency;
            this.MaxCycles = MaxCycles;
            this.WorkerThread = null;
            this.CycleCount = 0;
        }

        public readonly uint CoreNumber;

        public readonly TimeSpan Frequency;

        public readonly ulong? MaxCycles;

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

        readonly Func<T,T> Worker;

        ulong CycleCount;

        ProcessThread WorkerThread;

        T State;

        IRngContext Context;

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
            WorkerThread = task.thread(CurrentProcess.CurrentThreadId).ValueOrDefault();
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
            return AppMsg.Colorize(msgText, AppMsgColor.Magenta);
        }    
    }
}