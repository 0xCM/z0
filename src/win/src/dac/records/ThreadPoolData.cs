//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct ThreadPoolData
    {
        public readonly int CpuUtilization;
 
        public readonly int NumIdleWorkerThreads;
 
        public readonly int NumWorkingWorkerThreads;
 
        public readonly int NumRetiredWorkerThreads;
 
        public readonly int MinLimitTotalWorkerThreads;
 
        public readonly int MaxLimitTotalWorkerThreads;

        public readonly ClrDataAddress FirstUnmanagedWorkRequest;
 
        public readonly ClrDataAddress HillClimbingLog;

        public readonly int HillClimbingLogFirstIndex;

        public readonly int HillClimbingLogSize;

        public readonly int NumTimers;

        public readonly int NumCPThreads;

        public readonly int NumFreeCPThreads;

        public readonly int MaxFreeCPThreads;

        public readonly int NumRetiredCPThreads;

        public readonly int MaxLimitTotalCPThreads;

        public readonly int CurrentLimitTotalCPThreads;

        public readonly int MinLimitTotalCPThreads;

        public readonly ClrDataAddress AsyncTimerCallbackCompletionFPtr;
    }
}