//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.MS;
    using static ClrDataModel;

    /// <summary>
    /// Represents a root that comes from the finalizer queue.
    /// </summary>
    public class ClrFinalizerRoot : IClrRoot
    {
        public ulong Address { get; }
        
        public ClrObject Object { get; }
        
        public ClrRootKind RootKind => ClrRootKind.FinalizerQueue;
        
        public bool IsInterior => false;
        
        public bool IsPinned => false;

        public ClrFinalizerRoot(ulong address, ClrObject obj)
        {
            Address = address;
            Object = obj;
        }

        public override string ToString() => $"finalization root @{Address:x12} -> {Object}";
    }
}