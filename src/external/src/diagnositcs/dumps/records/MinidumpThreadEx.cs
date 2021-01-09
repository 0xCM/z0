// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace Z0
{
    using System.Runtime.InteropServices;

    public struct MinidumpThreadEx
    {
        public uint ThreadId;

        public uint SuspendCount;

        public uint PriorityClass;

        public uint Priority;

        public ulong Teb;

        public MinidumpMemoryDescriptor Stack;

        public MinidumpLocationDescriptor ThreadContext;

        public MinidumpMemoryDescriptor BackingStore;
    }
}