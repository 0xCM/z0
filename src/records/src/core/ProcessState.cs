//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Diagnostics;

    [StructLayout(LayoutKind.Sequential)]
    public struct ProcessState
    {
        /// <summary>
        /// The process identifier
        /// </summary>
        public uint Id;

        /// <summary>
        /// The process name
        /// </summary>
        public StringRef Name;

        /// <summary>
        /// The base address of the process
        /// </summary>
        public MemoryAddress Base;

        /// <summary>
        /// Captures the min/max working set size
        /// </summary>
        public ClosedInterval<ulong> Capacity;

        /// <summary>
        /// The cpu affinity provided by <see cref='Process.ProcessorAffinity'/>
        /// </summary>
        public ushort Affinity;

        /// <summary>
        /// Captures the process start time
        /// </summary>
        public Timestamp StartTime;

        /// <summary>
        /// Captures the value provided by <see cref='Process.TotalProcessorTime'/>
        /// </summary>
        public Duration TotalRuntime;

        /// <summary>
        /// Captures the value provided by <see cref='Process.UserProcessorTime'/>
        /// </summary>
        public Duration UserRuntime;

        /// <summary>
        /// The process main module
        /// </summary>
        public ProcessModuleRecord Main;
    }
}