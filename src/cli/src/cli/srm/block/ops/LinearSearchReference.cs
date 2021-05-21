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

            // Always RowNumber....
            public int LinearSearchReference(int rowSize, int referenceOffset, uint referenceValue, bool isReferenceSmall)
            {
                int currOffset = referenceOffset;
                int totalSize = this.Length;
                while (currOffset < totalSize)
                {
                    uint currReference = PeekReferenceUnchecked(currOffset, isReferenceSmall);
                    if (currReference == referenceValue)
                    {
                        return currOffset / rowSize;
                    }

                    currOffset += rowSize;
                }

                return -1;
            }
        }
    }
}