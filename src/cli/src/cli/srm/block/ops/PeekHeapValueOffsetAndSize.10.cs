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
            [MethodImpl(Inline)]
            public static bool create(byte* buffer, int length, out MemoryBlock dst)
            {
                dst = default;
                if (length < 0)
                    return false;

                if (buffer == null && length != 0)
                    return false;

                dst = new MemoryBlock(buffer, length);
                return true;
            }

            public static MemoryBlock CreateChecked(byte* buffer, int length)
            {
                if (length < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(length));
                }

                if (buffer == null && length != 0)
                {
                    throw new ArgumentNullException(nameof(buffer));
                }

                return new MemoryBlock(buffer, length);
            }
        }
    }
}