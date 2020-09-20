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

    using static Part;

    partial struct ClrStorageReaders
    {
        internal struct StringStreamReader
        {
            internal MemoryReader MemoryReader;

            internal string this[uint offset]
            {
                get
                    //^ requires offset >= 0 && offset < this.MemoryReader.Length;
                {
                    int bytesRead;
                    string str = this.MemoryReader.PeekUTF8NullTerminated((int)offset, out bytesRead);
                    //^ assert offset + bytesRead <= this.MemoryReader.Length;
                    return str;
                }
            }
        }


        internal struct UserStringStreamReader
        {
            internal MemoryReader MemoryReader;

            internal string this[uint offset]
            {
                get
                {
                    int bytesRead;
                    int numberOfBytes = MemoryReader.PeekCompressedInt32((int)offset, out bytesRead);
                    if (numberOfBytes == -1)
                        return string.Empty;

                    return this.MemoryReader.PeekUTF16WithSize((int)offset + bytesRead, numberOfBytes & ~1);
                }
            }

            internal IEnumerable<string> GetStrings()
            {
                int i = 1;
                while (i < this.MemoryReader.Length)
                {
                    int bytesRead;
                    int numberOfBytes = this.MemoryReader.PeekCompressedInt32(i, out bytesRead);
                    if (numberOfBytes < 1)
                    {
                        i += bytesRead;
                    }
                    else
                    {
                        yield return this.MemoryReader.PeekUTF16WithSize(i + bytesRead, numberOfBytes & ~1);
                        i += bytesRead + numberOfBytes;
                    }
                }
            }
        }
    }
}