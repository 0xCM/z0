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
            public void ReadColumn(uint[] result, int rowSize, int referenceOffset, bool isReferenceSmall)
            {
                int offset = referenceOffset;
                int totalSize = this.Length;

                int i = 0;
                while (offset < totalSize)
                {
                    result[i] = PeekReferenceUnchecked(offset, isReferenceSmall);
                    offset += rowSize;
                    i++;
                }

                //Debug.Assert(i == result.Length);
            }

        }
    }
}