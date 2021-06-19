//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/dotnet/runtime/src/libraries/System.Reflection.Metadata
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class SRM
    {
        unsafe partial struct MemoryBlock
        {
            [Op]
            public byte[] PeekBytes(int offset, int byteCount)
                => ReadBytes(Pointer + offset, byteCount);
        }
    }
}