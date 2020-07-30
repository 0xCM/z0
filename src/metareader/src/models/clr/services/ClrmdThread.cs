//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Collections.Generic;

    public sealed class ClrmdThread : ClrThread
    {
        readonly IThreadHelpers _helpers;

        readonly int _threadState;

        readonly ulong _exceptionHandle;

        public override ClrRuntime Runtime { get; }

        public override ulong Address { get; }

        public override bool IsFinalizer { get; }

        public override GCMode GCMode { get; }

        public override uint OSThreadId { get; }

        public override int ManagedThreadId { get; }

        public override ClrAppDomain CurrentAppDomain { get; }

        public override uint LockCount { get; }

        public override ulong StackBase { get; }

        public override ulong StackLimit { get; }

        public ClrmdThread(IThreadData data, ClrRuntime runtime, ClrAppDomain currentDomain)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            _helpers = data.Helpers;
            Runtime = runtime;
            Address = data.Address;
            IsFinalizer = data.IsFinalizer;
            OSThreadId = data.OSThreadID;
            ManagedThreadId = data.ManagedThreadID;
            CurrentAppDomain = currentDomain;
            LockCount = data.LockCount;
            _threadState = data.State;
            _exceptionHandle = data.ExceptionHandle;
            StackBase = data.StackBase;
            StackLimit = data.StackLimit;
            GCMode = data.Preemptive ? GCMode.Preemptive : GCMode.Cooperative;
        }

        public override ClrException? CurrentException
        {
            get
            {
                ulong ptr = _exceptionHandle;
                if (ptr == 0)
                    return null;

                ulong obj = _helpers.DataReader.ReadPointer(ptr);
                ulong mt = 0;
                if (obj != 0)
                    mt = _helpers.DataReader.ReadPointer(obj);

                if (mt != 0)
                {
                    ClrType? type = _helpers.Factory.GetOrCreateType(mt, obj);
                    if (type != null)
                        return new ClrException(_helpers.ExceptionHelpers, this, new ClrObject(obj, type));
                }

                return null;
            }
        }

        public override IEnumerable<ClrStackRoot> EnumerateStackRoots() 
            => _helpers.EnumerateStackRoots(this);

        public override IEnumerable<ClrStackFrame> EnumerateStackTrace(bool includeContext) 
            => _helpers.EnumerateStackTrace(this, includeContext);

        public override bool IsAborted 
            => (_threadState & (int)ThreadState.TS_Aborted) == (int)ThreadState.TS_Aborted;
        
        public override bool IsGCSuspendPending 
            => (_threadState & (int)ThreadState.TS_GCSuspendPending) == (int)ThreadState.TS_GCSuspendPending;
        
        public override bool IsUserSuspended 
            => (_threadState & (int)ThreadState.TS_UserSuspendPending) == (int)ThreadState.TS_UserSuspendPending;
        
        public override bool IsDebugSuspended 
            => (_threadState & (int)ThreadState.TS_DebugSuspendPending) == (int)ThreadState.TS_DebugSuspendPending;
        
        public override bool IsBackground 
            => (_threadState & (int)ThreadState.TS_Background) == (int)ThreadState.TS_Background;
        
        public override bool IsUnstarted 
            => (_threadState & (int)ThreadState.TS_Unstarted) == (int)ThreadState.TS_Unstarted;
        
        public override bool IsCoInitialized => (_threadState & (int)ThreadState.TS_CoInitialized) == (int)ThreadState.TS_CoInitialized;
        
        public override bool IsSTA 
            => (_threadState & (int)ThreadState.TS_InSTA) == (int)ThreadState.TS_InSTA;
        
        public override bool IsMTA 
            => (_threadState & (int)ThreadState.TS_InMTA) == (int)ThreadState.TS_InMTA;

        public override bool IsAbortRequested =>
            (_threadState & (int)ThreadState.TS_AbortRequested) == (int)ThreadState.TS_AbortRequested
            || (_threadState & (int)ThreadState.TS_AbortInitiated) == (int)ThreadState.TS_AbortInitiated;

        public override bool IsAlive => OSThreadId != 0 && (_threadState & ((int)ThreadState.TS_Unstarted | (int)ThreadState.TS_Dead)) == 0;
   }
}