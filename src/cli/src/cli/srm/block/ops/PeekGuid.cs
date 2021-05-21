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
            public Guid PeekGuid(int offset)
            {
                Available(offset, sizeof(Guid));

                byte* ptr = Pointer + offset;
                if (BitConverter.IsLittleEndian)
                    return *(Guid*)ptr;
                else
                {
                    unchecked
                    {
                        return new Guid(
                            (int)(ptr[0] | (ptr[1] << 8) | (ptr[2] << 16) | (ptr[3] << 24)),
                            (short)(ptr[4] | (ptr[5] << 8)),
                            (short)(ptr[6] | (ptr[7] << 8)),
                            ptr[8], ptr[9], ptr[10], ptr[11], ptr[12], ptr[13], ptr[14], ptr[15]);
                    }
                }
            }
        }
    }
}