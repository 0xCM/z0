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
            [MethodImpl(Inline), Op]
            public int PeekInt32(int offset)
            {
                uint result = PeekUInt32(offset);
                if (unchecked((int)result != result))
                {
                    //Throw.ValueOverflow();
                }

                return (int)result;
            }
        }
    }
}