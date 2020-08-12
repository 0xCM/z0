//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct ThreadPoolData
    {
        public int CpuUtilization;
 
        public int NumIdleWorkerThreads;
 
        public int NumWorkingWorkerThreads;
 
        public int NumRetiredWorkerThreads;
 
        public int MinLimitTotalWorkerThreads;
 
        public int MaxLimitTotalWorkerThreads;

        public ClrDataAddress FirstUnmanagedWorkRequest;
 
        public ClrDataAddress HillClimbingLog;

        public int HillClimbingLogFirstIndex;

        public int HillClimbingLogSize;

        public int NumTimers;

        public int NumCPThreads;

        public int NumFreeCPThreads;

        public int MaxFreeCPThreads;

        public int NumRetiredCPThreads;

        public int MaxLimitTotalCPThreads;

        public int CurrentLimitTotalCPThreads;

        public int MinLimitTotalCPThreads;

        public ClrDataAddress AsyncTimerCallbackCompletionFPtr;
    }
}