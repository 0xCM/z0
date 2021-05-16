//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection;
    using System.Reflection.Metadata;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class SRM
    {
        public readonly struct UserStringHeap : ISrmHeap<UserStringHeap>
        {
            public MemoryBlock Block {get;}

            public CliHeapKind HeapKind
            {
                [MethodImpl(Inline)]
                get => CliHeapKind.UserString;
            }

            [MethodImpl(Inline)]
            public UserStringHeap(MemoryBlock block)
                => Block = block;

            public string GetString(UserStringHandle handle)
            {
                int offset, size;
                if (!Block.PeekHeapValueOffsetAndSize(handle.GetHeapOffset(), out offset, out size))
                {
                    return string.Empty;
                }

                // Spec: Furthermore, there is an additional terminal byte (so all byte counts are odd, not even).
                // The size in the blob header is the length of the string in bytes + 1.
                return Block.PeekUtf16(offset, size & ~1);
            }

            public UserStringHandle GetNextHandle(UserStringHandle handle)
            {
                int offset, size;
                if (!Block.PeekHeapValueOffsetAndSize(handle.GetHeapOffset(), out offset, out size))
                {
                    return default(UserStringHandle);
                }

                int nextIndex = offset + size;
                if (nextIndex >= Block.Length)
                {
                    return default(UserStringHandle);
                }

                return UserStringHandle.FromOffset(nextIndex);
            }
        }
    }
}