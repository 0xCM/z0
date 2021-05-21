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
            // same as Array.BinarySearch, but without using IComparer
            [Op]
            public int BinarySearch(string[] asciiKeys, int offset)
            {
                var low = 0;
                var high = asciiKeys.Length - 1;

                while (low <= high)
                {
                    var middle = low + ((high - low) >> 1);
                    var midValue = asciiKeys[middle];

                    int comparison = CompareUtf8NullTerminatedStringWithAsciiString(offset, midValue);
                    if (comparison == 0)
                    {
                        return middle;
                    }

                    if (comparison < 0)
                    {
                        high = middle - 1;
                    }
                    else
                    {
                        low = middle + 1;
                    }
                }

                return ~low;
            }

            /// <summary>
            /// In a table that specifies children via a list field (e.g. TypeDef.FieldList, TypeDef.MethodList),
            /// searches for the parent given a reference to a child.
            /// </summary>
            /// <returns>Returns row number [0..RowCount).</returns>
            [Op]
            public int BinarySearchForSlot(
                int rowCount,
                int rowSize,
                int referenceListOffset,
                uint referenceValue,
                bool isReferenceSmall)
            {
                int startRowNumber = 0;
                int endRowNumber = rowCount - 1;
                uint startValue = PeekReferenceUnchecked(startRowNumber * rowSize + referenceListOffset, isReferenceSmall);
                uint endValue = PeekReferenceUnchecked(endRowNumber * rowSize + referenceListOffset, isReferenceSmall);
                if (endRowNumber == 1)
                {
                    if (referenceValue >= endValue)
                    {
                        return endRowNumber;
                    }

                    return startRowNumber;
                }

                while (endRowNumber - startRowNumber > 1)
                {
                    if (referenceValue <= startValue)
                    {
                        return referenceValue == startValue ? startRowNumber : startRowNumber - 1;
                    }

                    if (referenceValue >= endValue)
                    {
                        return referenceValue == endValue ? endRowNumber : endRowNumber + 1;
                    }

                    int midRowNumber = (startRowNumber + endRowNumber) / 2;
                    uint midReferenceValue = PeekReferenceUnchecked(midRowNumber * rowSize + referenceListOffset, isReferenceSmall);
                    if (referenceValue > midReferenceValue)
                    {
                        startRowNumber = midRowNumber;
                        startValue = midReferenceValue;
                    }
                    else if (referenceValue < midReferenceValue)
                    {
                        endRowNumber = midRowNumber;
                        endValue = midReferenceValue;
                    }
                    else
                    {
                        return midRowNumber;
                    }
                }

                return startRowNumber;
            }

            /// <summary>
            /// In a table ordered by a column containing entity references searches for a row with the specified reference.
            /// </summary>
            /// <returns>Returns row number [0..RowCount) or -1 if not found.</returns>
            [Op]
            public int BinarySearchReference(
                int rowCount,
                int rowSize,
                int referenceOffset,
                uint referenceValue,
                bool isReferenceSmall)
            {
                int startRowNumber = 0;
                int endRowNumber = rowCount - 1;
                while (startRowNumber <= endRowNumber)
                {
                    int midRowNumber = (startRowNumber + endRowNumber) / 2;
                    uint midReferenceValue = PeekReferenceUnchecked(midRowNumber * rowSize + referenceOffset, isReferenceSmall);
                    if (referenceValue > midReferenceValue)
                    {
                        startRowNumber = midRowNumber + 1;
                    }
                    else if (referenceValue < midReferenceValue)
                    {
                        endRowNumber = midRowNumber - 1;
                    }
                    else
                    {
                        return midRowNumber;
                    }
                }

                return -1;
            }

            // Row number [0, ptrTable.Length) or -1 if not found.
            [Op]
            public int BinarySearchReference(
                int[] ptrTable,
                int rowSize,
                int referenceOffset,
                uint referenceValue,
                bool isReferenceSmall)
            {
                int startRowNumber = 0;
                int endRowNumber = ptrTable.Length - 1;
                while (startRowNumber <= endRowNumber)
                {
                    int midRowNumber = (startRowNumber + endRowNumber) / 2;
                    uint midReferenceValue = PeekReferenceUnchecked((ptrTable[midRowNumber] - 1) * rowSize + referenceOffset, isReferenceSmall);
                    if (referenceValue > midReferenceValue)
                    {
                        startRowNumber = midRowNumber + 1;
                    }
                    else if (referenceValue < midReferenceValue)
                    {
                        endRowNumber = midRowNumber - 1;
                    }
                    else
                    {
                        return midRowNumber;
                    }
                }

                return -1;
            }

            /// <summary>
            /// Calculates a range of rows that have specified value in the specified column in a table that is sorted by that column.
            /// </summary>
            [Op]
            public void BinarySearchReferenceRange(
                int rowCount,
                int rowSize,
                int referenceOffset,
                uint referenceValue,
                bool isReferenceSmall,
                out int startRowNumber, // [0, rowCount) or -1
                out int endRowNumber)   // [0, rowCount) or -1
            {
                int foundRowNumber = BinarySearchReference(
                    rowCount,
                    rowSize,
                    referenceOffset,
                    referenceValue,
                    isReferenceSmall
                );

                if (foundRowNumber == -1)
                {
                    startRowNumber = -1;
                    endRowNumber = -1;
                    return;
                }

                startRowNumber = foundRowNumber;
                while (startRowNumber > 0 &&
                    PeekReferenceUnchecked((startRowNumber - 1) * rowSize + referenceOffset, isReferenceSmall) == referenceValue)
                {
                    startRowNumber--;
                }

                endRowNumber = foundRowNumber;
                while (endRowNumber + 1 < rowCount &&
                    PeekReferenceUnchecked((endRowNumber + 1) * rowSize + referenceOffset, isReferenceSmall) == referenceValue)
                {
                    endRowNumber++;
                }
            }

            /// <summary>
            /// Calculates a range of rows that have specified value in the specified column in a table that is sorted by that column.
            /// </summary>
            [Op]
            public void BinarySearchReferenceRange(int[] ptrTable, int rowSize, int referenceOffset, uint referenceValue, bool isReferenceSmall,
                out int startRowNumber, // [0, ptrTable.Length) or -1
                out int endRowNumber)   // [0, ptrTable.Length) or -1
            {
                int foundRowNumber = BinarySearchReference(
                    ptrTable,
                    rowSize,
                    referenceOffset,
                    referenceValue,
                    isReferenceSmall
                );

                if (foundRowNumber == -1)
                {
                    startRowNumber = -1;
                    endRowNumber = -1;
                    return;
                }

                startRowNumber = foundRowNumber;
                while (startRowNumber > 0 &&
                    PeekReferenceUnchecked((ptrTable[startRowNumber - 1] - 1) * rowSize + referenceOffset, isReferenceSmall) == referenceValue)
                {
                    startRowNumber--;
                }

                endRowNumber = foundRowNumber;
                while (endRowNumber + 1 < ptrTable.Length &&
                    PeekReferenceUnchecked((ptrTable[endRowNumber + 1] - 1) * rowSize + referenceOffset, isReferenceSmall) == referenceValue)
                {
                    endRowNumber++;
                }
            }
        }
    }
}