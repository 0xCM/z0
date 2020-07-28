//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;

    using Z0.Dac;    

    using static ClrDataModel;    

    internal class ThreadBuilder : IThreadData
    {
        private readonly SOSDac _sos;

        private readonly ulong _finalizer;

        private ThreadData _threadData;

        public ThreadBuilder(SOSDac sos, ulong finalizer, IThreadHelpers helpers)
        {
            _sos = sos;
            _finalizer = finalizer;
            Helpers = helpers;
        }

        public ulong Address { get; private set; }

        public IThreadHelpers Helpers { get; }

        public bool Init(ulong address)
        {
            Address = address;
            return _sos.GetThreadData(Address, out _threadData);
        }

        bool IThreadData.IsFinalizer => _finalizer == Address;

        uint IThreadData.OSThreadID => _threadData.OSThreadId;

        int IThreadData.ManagedThreadID => (int)_threadData.ManagedThreadId;

        uint IThreadData.LockCount => _threadData.LockCount;

        int IThreadData.State => _threadData.State;

        ulong IThreadData.ExceptionHandle => _threadData.LastThrownObjectHandle;

        bool IThreadData.Preemptive => _threadData.PreemptiveGCDisabled == 0;

        ulong IThreadData.StackBase
        {
            get
            {
                if (_threadData.Teb == 0)
                    return 0;

                ulong ptr = _threadData.Teb + (ulong)IntPtr.Size;
                if (!Helpers.DataReader.ReadPointer(ptr, out ptr))
                    return 0;

                return ptr;
            }
        }

        ulong IThreadData.StackLimit
        {
            get
            {
                if (_threadData.Teb == 0)
                    return 0;

                ulong ptr = _threadData.Teb + (ulong)IntPtr.Size * 2;
                if (!Helpers.DataReader.ReadPointer(ptr, out ptr))
                    return 0;

                return ptr;
            }
        }

        public ulong NextThread 
            => _threadData.NextThread;
        
        public ulong Domain 
            => _threadData.Domain;
    }
}