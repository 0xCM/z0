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

            // #String, #Blob heaps
            [MethodImpl(Inline), Op]
            public int PeekHeapReference(int offset, bool smallRefSize)
            {
                if (smallRefSize)
                    return PeekUInt16(offset);

                var value = PeekUInt32(offset);

                //if (!HeapHandleType.IsValidHeapOffset(value))
                //{
                    //Throw.ReferenceOverflow();
                //}

                return (int)value;
            }
        }
    }
}