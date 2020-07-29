//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;

    using Z0.MS;

    using static ClrDataModel;

    public struct ClrStackRoot : IClrRoot
    {
        public ulong Address { get; }
        public ClrObject Object { get; }
        public ClrStackFrame StackFrame { get; }
        public ClrRootKind RootKind => ClrRootKind.Stack;
        public bool IsInterior { get; }
        public bool IsPinned { get; }

        public ClrStackRoot(ulong address, ClrObject obj, ClrStackFrame stackFrame, bool interior, bool pinned)
        {
            Address = address;
            Object = obj;
            StackFrame = stackFrame;
            IsInterior = interior;
            IsPinned = pinned;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            ClrThread thread = StackFrame.Thread;
            if (thread != null)
                builder.Append($"Thread {thread.OSThreadId:x} ");

            builder.Append(StackFrame);
            builder.Append($" @{Address:x12} -> {Object}");
            return builder.ToString();
        }
    }        

}