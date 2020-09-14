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

    using static Konst;

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
    }
}