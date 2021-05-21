//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/dotnet/runtime/src/libraries/System.Reflection.Metadata
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
        unsafe partial struct MemoryBlock
        {
            [Op]
            public int IndexOf(byte b, int start)
            {
                Available(start, 0);
                return IndexOfUnchecked(b, start);
            }

            [MethodImpl(Inline), Op]
            public int IndexOfUnchecked(byte b, int start)
            {
                byte* p = Pointer + start;
                byte* end = Pointer + Length;
                while (p < end)
                {
                    if (*p == b)
                    {
                        return (int)(p - Pointer);
                    }

                    p++;
                }

                return -1;
            }
        }
    }
}