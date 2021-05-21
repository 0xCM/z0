//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/dotnet/runtime/src/libraries/System.Reflection.Metadata
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class SRM
    {
        unsafe partial struct MemoryBlock
        {
            [Op]
            public byte[] PeekBytes(int offset, int byteCount)
            {
                Available(offset, byteCount);
                return ReadBytes(Pointer + offset, byteCount);
            }
        }
    }
}