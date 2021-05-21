//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/dotnet/runtime/src/libraries/System.Reflection.Metadata
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Part;

    partial class SRM
    {
        public readonly struct UserStringHeap
        {
            [MethodImpl(Inline), Op]
            public static UserStringHandle HandleFromOffset(int heapOffset)
                => core.@as<int, UserStringHandle>(heapOffset);

            internal readonly MemoryBlock Block;

            [MethodImpl(Inline), Op]
            public UserStringHeap(MemoryBlock block)
            {
                Block = block;
            }

            public MemoryAddress BaseAddress
            {
                [MethodImpl(Inline)]
                get => Block.BaseAddress;
            }

            public string GetString(UserStringHandle handle)
            {
                int offset, size;
                if (!Block.PeekHeapValueOffsetAndSize(handle.GetHeapOffset(), out offset, out size))
                    return EmptyString;

                // Spec: Furthermore, there is an additional terminal byte (so all byte counts are odd, not even).
                // The size in the blob header is the length of the string in bytes + 1.
                return Block.PeekUtf16(offset, size & ~1);
            }

            public UserStringHandle GetNextHandle(UserStringHandle handle)
            {
                int offset, size;
                if (!Block.PeekHeapValueOffsetAndSize(handle.GetHeapOffset(), out offset, out size))
                    return default(UserStringHandle);

                var nextIndex = offset + size;
                if (nextIndex >= Block.Length)
                    return default(UserStringHandle);

                return HandleFromOffset(nextIndex);
            }
        }
    }
}