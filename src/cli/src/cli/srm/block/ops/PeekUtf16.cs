//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/dotnet/runtime/src/libraries/System.Reflection.Metadata
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Part;
    using static memory;

    partial class SRM
    {
        unsafe partial struct MemoryBlock
        {
            [Op]
            public string PeekUtf16(int offset, int byteCount)
            {
                Available(offset, byteCount);

                byte* ptr = Pointer + offset;
                if (BitConverter.IsLittleEndian)
                {
                    // doesn't allocate a new string if byteCount == 0
                    return new string((char*)ptr, 0, byteCount / sizeof(char));
                }
                else
                    return Encoding.Unicode.GetString(ptr, byteCount);
            }
        }
    }
}