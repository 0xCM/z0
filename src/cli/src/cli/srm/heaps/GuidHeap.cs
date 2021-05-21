//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/dotnet/runtime/src/libraries/System.Reflection.Metadata
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Metadata;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class SRM
    {
        public readonly struct GuidHeap
        {
            internal readonly MemoryBlock Block;

            [MethodImpl(Inline)]
            public GuidHeap(MemoryBlock block)
            {
                Block = block;
            }

            public MemoryAddress BaseAddress
            {
                [MethodImpl(Inline)]
                get => Block.BaseAddress;
            }

            public Guid GetGuid(GuidHandle handle)
            {
                if (handle.IsNil)
                {
                    return default(Guid);
                }

                // Metadata Spec: The Guid heap is an array of GUIDs, each 16 bytes wide.
                // Its first element is numbered 1, its second 2, and so on.
                return Block.PeekGuid((handle.Index() - 1) * SizeOfGuid);
            }
        }
    }
}