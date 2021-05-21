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

            public int[] BuildPtrTable(int numberOfRows, int rowSize, int referenceOffset, bool isReferenceSmall)
            {
                int[] ptrTable = new int[numberOfRows];
                uint[] unsortedReferences = new uint[numberOfRows];

                for (int i = 0; i < ptrTable.Length; i++)
                {
                    ptrTable[i] = i + 1;
                }

                ReadColumn(unsortedReferences, rowSize, referenceOffset, isReferenceSmall);
                Array.Sort(ptrTable, (int a, int b) => { return unsortedReferences[a - 1].CompareTo(unsortedReferences[b - 1]); });
                return ptrTable;
            }

        }
    }
}