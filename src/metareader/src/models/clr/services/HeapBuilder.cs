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

    internal sealed class HeapBuilder : IHeapBuilder
    {
        private readonly CommonMethodTables _mts;

        public IHeapHelpers HeapHelpers { get; }

        public bool IsServer { get; }

        public int LogicalHeapCount { get; }

        public ulong ArrayMethodTable 
            => _mts.ArrayMethodTable;

        public ulong StringMethodTable 
            => _mts.StringMethodTable;

        public ulong ObjectMethodTable 
            => _mts.ObjectMethodTable;

        public ulong ExceptionMethodTable 
            => _mts.ExceptionMethodTable;

        public ulong FreeMethodTable 
            => _mts.FreeMethodTable;

        public bool CanWalkHeap { get; }
    
        public HeapBuilder(IHeapHelpers helper, SOSDac sos)
        {
            HeapHelpers = helper;

            if (sos.GetCommonMethodTables(out _mts))
                CanWalkHeap = ArrayMethodTable != 0 && StringMethodTable != 0 && ExceptionMethodTable != 0 && FreeMethodTable != 0 && ObjectMethodTable != 0;

            if (sos.GetGCHeapData(out GCInfo gcdata))
            {
                if (gcdata.MaxGeneration != 2)
                    throw new NotSupportedException($"The GC reported a max generation of {gcdata.MaxGeneration} which this build of ClrMD does not support.");

                IsServer = gcdata.ServerMode != 0;
                LogicalHeapCount = gcdata.HeapCount;
                CanWalkHeap &= gcdata.GCStructuresValid != 0;
            }
            else
            {
                CanWalkHeap = false;
            }
        }
    }
}