//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Runtime.InteropServices;
    using System.Text;

    using static Part;
    using static memory;

    partial class SRM
    {
        [MethodImpl(Inline), Op]
        public static bool available(MemoryBlock src, uint offset, ByteSize wanted)
        {
            if (unchecked((ulong)(uint)offset + (uint)wanted) > (ulong)src.Length)
                return false;
            else
                return true;
        }
    }
}