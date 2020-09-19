//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static Konst;
    using static ClrStorage;

    partial struct ClrStorageReaders
    {
        internal struct BlobStreamReader
        {
            static internal byte[] Empty = new byte[0];

            internal MemoryReader MemoryReader;

            internal byte[] this[uint offset]
            {
                get
                {
                    int bytesRead;
                    int numberOfBytes = this.MemoryReader.PeekCompressedInt32((int)offset, out bytesRead);
                    if (numberOfBytes == -1)
                        return BlobStreamReader.Empty;

                    return MemoryReader.PeekBytes((int)offset + bytesRead, numberOfBytes);
                }
            }

            internal byte GetByteAt(uint offset, int index)
            {
                int bytesRead;
                int numberOfBytes = this.MemoryReader.PeekCompressedInt32((int)offset, out bytesRead);
                if (index >= numberOfBytes)
                    return 0;
                return MemoryReader.PeekByte((int)offset + bytesRead + index);
            }

            internal MemoryBlock GetMemoryBlockAt(uint offset)
            {
                uint numberOfBytes = MemoryReader.PeekCompressedUInt32(offset, out var bytesRead);
                return MemoryReader.GetMemoryBlockAt(offset + bytesRead, numberOfBytes);
            }
        }
    }
}