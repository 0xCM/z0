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
            public bool IsOrderedByReferenceAscending(int rowSize, int referenceOffset, bool isReferenceSmall)
            {
                int offset = referenceOffset;
                int totalSize = this.Length;

                uint previous = 0;
                while (offset < totalSize)
                {
                    uint current = PeekReferenceUnchecked(offset, isReferenceSmall);
                    if (current < previous)
                    {
                        return false;
                    }

                    previous = current;
                    offset += rowSize;
                }

                return true;
            }
        }
    }
}