//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Security;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    using System.Linq;

    using static Root;

    /// <summary>
    /// Defines counter api surface
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public static unsafe class SystemCounters
    {
        public static readonly long CounterFrequency;
        
        /// <summary>
        /// Returns the difference between the current Counter value and a prior counter value
        /// </summary>
        [MethodImpl(Inline)]
        public static long CounterDelta(in long prior)
            => Counter - prior;

        /// <summary>
        /// Converts a counter value to milliseconds
        /// </summary>
        /// <param name="count">The count value to convert</param>
        [MethodImpl(Inline)]
        public static double CounterMs(in long count)
            => ((double)count)/((double) CounterFrequency);

        /// <summary>
        /// Gets the current value of the counter
        /// </summary>
        public static long Counter
        {            
            [MethodImpl(Inline)]
            get
            {
                var count = 0L;
                QueryPerformanceCounter(ref count);
                return count;
            }
        }

        [MethodImpl(Inline)]
        public static ref long GetCount(ref long count)
        {
            QueryPerformanceCounter(ref count);
            return ref count;
        }

        /// <summary>
        /// Gets the CPU cycles consumed by the calling thread
        /// </summary>
        public static ulong ThreadCpuCycles 
        {
            [MethodImpl(Inline)]
            get
            {
                var cycles = 0ul;
                if (!QueryThreadCycleTime((IntPtr)(-2), ref cycles))
                    return 0ul;
                return cycles;
            }
        }

        static SystemCounters()
        {
            QueryPerformanceFrequency(ref CounterFrequency);
        }
        
        [DllImport(Kernel32)]
        static extern int QueryPerformanceCounter(ref long count);
        
        /// <summary>
        /// Retrieves the number of performance counter counts per second.
        /// </summary>
        /// <remarks>This is determined by the OS at boot time and is invariant until the next reboot</remarks>
        [DllImport(Kernel32)]
        static extern int QueryPerformanceFrequency(ref long frequency);

        /// <summary>
        /// Retrieves the cyle time for a specified thread
        /// </summary>
        /// <param name="hThread">The handle to the thread</param>
        /// <param name="cycles">The number of cpu clock cycles used by the thread</param>
        [DllImport(Kernel32)]
        static extern bool QueryThreadCycleTime(IntPtr hThread, ref ulong cycles);

        /// <summary>
        /// Retrieves the sum of the cycle time of all threads of the specified process.
        /// </summary>
        /// <param name="hProc">The handle to the process</param>
        /// <param name="cycles">The number of cpu clock cycles used by the threads of the process</param>
        [DllImport(Kernel32)]
        static extern bool QueryProcessCycleTime(IntPtr hProc, ref ulong cycles);

        [DllImport(Kernel32)]
        static extern void QueryInterruptTime(ref ulong time);

        [DllImport(Kernel32)]
        static extern void QueryInterruptTimePrecise(ref ulong time);

    }
}