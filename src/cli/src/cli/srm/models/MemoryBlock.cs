//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
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
        public const int InvalidCompressedInteger = int.MaxValue;

        [MethodImpl(Inline), Op]
        public static unsafe uint unpack(byte* pSrc, uint length, uint offset, out ByteSize consumed)
        {
            byte* ptr = pSrc + offset;
            var limit = length - offset;
            consumed = 0;

            if (limit == 0)
                return uint.MaxValue;

            var lead = (uint)ptr[0];
            if ((lead & 0x80) == 0)
            {
                consumed = 1;
                return lead;
            }
            else if((lead & 0x40) == 0)
            {
                if (limit >= 2)
                {
                    consumed = 2;
                    return ((lead & 0x3fu) << 8) | (uint)ptr[1];
                }
            }
            else if ((lead & 0x20) == 0)
            {
                if (limit >= 4)
                {
                    consumed = 4;
                    return ((lead & 0x1fu) << 24) | ((uint)ptr[1] << 16) | ((uint)ptr[2] << 8) | (uint)ptr[3];
                }
            }

            return uint.MaxValue;
        }

        [MethodImpl(Inline), Op]
        public static unsafe uint unpack(MemoryBlock src, uint offset, out ByteSize consumed)
            => unpack(src.Pointer, (uint)src.Length, offset, out consumed);

        [MethodImpl(Inline), Op]
        public static bool available(MemoryBlock src, uint offset, ByteSize wanted)
        {
            if (unchecked((ulong)(uint)offset + (uint)wanted) > (ulong)src.Length)
                return false;
            else
                return true;
        }

        [MethodImpl(Inline), Op]
        public static unsafe MemoryBlock block(MemoryBlock src, uint offset, ByteSize length)
        {
            if(available(src, offset, length))
                return new MemoryBlock(src.Pointer + offset, length);
            else
                return MemoryBlock.Empty;
        }

        [ApiHost("srm.memoryblock")]
        public readonly unsafe struct MemoryBlock
        {
            public readonly byte* Pointer;

            public readonly int Length;

            [MethodImpl(Inline)]
            public MemoryBlock(byte* buffer, int length)
            {
                Pointer = buffer;
                Length = length;
            }

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Length == 0;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => Length != 0;
            }

            public static MemoryBlock Empty
            {
                [MethodImpl(Inline)]
                get => new MemoryBlock(memory.gptr(first(Array.Empty<byte>())),0);
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

            [MethodImpl(Inline), Op]
            bool Available(int offset, int byteCount)
                => available(this,(uint)offset, byteCount);

            [Op]
            public byte[]? ToArray()
            {
                return Pointer == null ? null : PeekBytes(0, Length);
            }

            string GetDebuggerDisplay()
            {
                if (Pointer == null)
                {
                    return "<null>";
                }

                int displayedBytes;
                return GetDebuggerDisplay(out displayedBytes);
            }

            public string GetDebuggerDisplay(out int displayedBytes)
            {
                displayedBytes = Math.Min(Length, 64);
                string result = BitConverter.ToString(PeekBytes(0, displayedBytes));
                if (displayedBytes < Length)
                {
                    result += "-...";
                }

                return result;
            }

            [Op]
            public static byte[] ReadBytes(byte* pSrc, int byteCount)
            {
                if (byteCount == 0)
                    return sys.empty<byte>();

                var dst = new byte[byteCount];
                Marshal.Copy((IntPtr)pSrc, dst, 0, byteCount);
                return dst;
            }

            public string GetDebuggerDisplay(int offset)
            {
                if (Pointer == null)
                {
                    return "<null>";
                }

                int displayedBytes;
                string display = GetDebuggerDisplay(out displayedBytes);
                if (offset < displayedBytes)
                {
                    display = display.Insert(offset * 3, "*");
                }
                else if (displayedBytes == Length)
                {
                    display += "*";
                }
                else
                {
                    display += "*...";
                }

                return display;
            }

            [Op]
            public MemoryBlock GetMemoryBlockAt(int offset, int length)
                => block(this, (uint)offset, length);

            [Op]
            public byte PeekByte(int offset)
            {
                Available(offset, sizeof(byte));
                return Pointer[offset];
            }

            [Op]
            public int PeekInt32(int offset)
            {
                uint result = PeekUInt32(offset);
                if (unchecked((int)result != result))
                {
                    //Throw.ValueOverflow();
                }

                return (int)result;
            }

            [MethodImpl(Inline), Op]
            public uint PeekUInt32(int offset)
            {
                Available(offset, sizeof(uint));

                unchecked
                {
                    byte* ptr = Pointer + offset;
                    return (uint)(ptr[0] | (ptr[1] << 8) | (ptr[2] << 16) | (ptr[3] << 24));
                }
            }

            /// <summary>
            /// Decodes a compressed integer value starting at offset.
            /// See Metadata Specification section II.23.2: Blobs and signatures.
            /// </summary>
            /// <param name="offset">Offset to the start of the compressed data.</param>
            /// <param name="numberOfBytesRead">Bytes actually read.</param>
            /// <returns>
            /// Value between 0 and 0x1fffffff, or <see cref="BlobReader.InvalidCompressedInteger"/> if the value encoding is invalid.
            /// </returns>
            [Op]
            public int PeekCompressedInteger(int offset, out int numberOfBytesRead)
            {
                var result = (int)unpack(this, (uint)offset, out var consumed);
                numberOfBytesRead = (int)consumed;
                return result;
            }

            [MethodImpl(Inline), Op]
            public ushort PeekUInt16(int offset)
            {
                Available(offset, sizeof(ushort));

                unchecked
                {
                    byte* ptr = Pointer + offset;
                    return (ushort)(ptr[0] | (ptr[1] << 8));
                }
            }

            // When reference has tag bits.
            [Op]
            public uint PeekTaggedReference(int offset, bool smallRefSize)
                => PeekReferenceUnchecked(offset, smallRefSize);

            // Use when searching for a tagged or non-tagged reference.
            // The result may be an invalid reference and shall only be used to compare with a valid reference.
            [Op]
            public uint PeekReferenceUnchecked(int offset, bool smallRefSize)
            {
                return smallRefSize ? PeekUInt16(offset) : PeekUInt32(offset);
            }

            // When reference has at most 24 bits.
            [Op]
            public int PeekReference(int offset, bool smallRefSize)
            {
                if (smallRefSize)
                {
                    return PeekUInt16(offset);
                }

                uint value = PeekUInt32(offset);

                if (!TokenTypeIds.IsValidRowId(value))
                {
                    //Throw.ReferenceOverflow();
                }

                return (int)value;
            }

            // #String, #Blob heaps
            [Op]
            public int PeekHeapReference(int offset, bool smallRefSize)
            {
                if (smallRefSize)
                {
                    return PeekUInt16(offset);
                }

                uint value = PeekUInt32(offset);

                if (!HeapHandleType.IsValidHeapOffset(value))
                {
                    //Throw.ReferenceOverflow();
                }

                return (int)value;
            }

            [Op]
            public Guid PeekGuid(int offset)
            {
                Available(offset, sizeof(Guid));

                byte* ptr = Pointer + offset;
                if (BitConverter.IsLittleEndian)
                {
                    return *(Guid*)ptr;
                }
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

            [Op]
            public string PeekUtf16(int offset, int byteCount)
            {
                Available(offset, byteCount);

                byte* ptr = Pointer + offset;
                if (BitConverter.IsLittleEndian)
                {
                    // doesn't allocate a new string if byteCount == 0
                    return new string((char*)ptr, 0, byteCount / sizeof(char));
                }
                else
                {
                    return Encoding.Unicode.GetString(ptr, byteCount);
                }
            }

            [Op]
            public string PeekUtf8(int offset, int byteCount)
            {
                Available(offset, byteCount);
                return Encoding.UTF8.GetString(Pointer + offset, byteCount);
            }

            /// <summary>
            /// Read UTF8 at the given offset up to the given terminator, null terminator, or end-of-block.
            /// </summary>
            /// <param name="offset">Offset in to the block where the UTF8 bytes start.</param>
            /// <param name="prefix">UTF8 encoded prefix to prepend to the bytes at the offset before decoding.</param>
            /// <param name="utf8Decoder">The UTF8 decoder to use that allows user to adjust fallback and/or reuse existing strings without allocating a new one.</param>
            /// <param name="numberOfBytesRead">The number of bytes read, which includes the terminator if we did not hit the end of the block.</param>
            /// <param name="terminator">A character in the ASCII range that marks the end of the string.
            /// If a value other than '\0' is passed we still stop at the null terminator if encountered first.</param>
            /// <returns>The decoded string.</returns>
            [Op]
            public string PeekUtf8NullTerminated(int offset, byte[]? prefix, MetadataStringDecoder utf8Decoder, out int numberOfBytesRead, char terminator = '\0')
            {
                Debug.Assert(terminator <= 0x7F);
                Available(offset, 0);
                int length = GetUtf8NullTerminatedLength(offset, out numberOfBytesRead, terminator);
                return EncodingHelper.DecodeUtf8(Pointer + offset, length, prefix, utf8Decoder);
            }

            /// <summary>
            /// Get number of bytes from offset to given terminator, null terminator, or end-of-block (whichever comes first).
            /// Returned length does not include the terminator, but numberOfBytesRead out parameter does.
            /// </summary>
            /// <param name="offset">Offset in to the block where the UTF8 bytes start.</param>
            /// <param name="terminator">A character in the ASCII range that marks the end of the string.
            /// If a value other than '\0' is passed we still stop at the null terminator if encountered first.</param>
            /// <param name="numberOfBytesRead">The number of bytes read, which includes the terminator if we did not hit the end of the block.</param>
            /// <returns>Length (byte count) not including terminator.</returns>
            [Op]
            public int GetUtf8NullTerminatedLength(int offset, out int numberOfBytesRead, char terminator = '\0')
            {
                Available(offset, 0);

                Debug.Assert(terminator <= 0x7f);

                byte* start = Pointer + offset;
                byte* end = Pointer + Length;
                byte* current = start;

                while (current < end)
                {
                    byte b = *current;
                    if (b == 0 || b == terminator)
                    {
                        break;
                    }

                    current++;
                }

                int length = (int)(current - start);
                numberOfBytesRead = length;
                if (current < end)
                {
                    // we also read the terminator
                    numberOfBytesRead++;
                }

                return length;
            }

            [Op]
            public int Utf8NullTerminatedOffsetOfAsciiChar(int startOffset, char asciiChar)
            {
                Available(startOffset, 0);

                Debug.Assert(asciiChar != 0 && asciiChar <= 0x7f);

                for (int i = startOffset; i < Length; i++)
                {
                    byte b = Pointer[i];

                    if (b == 0)
                    {
                        break;
                    }

                    if (b == asciiChar)
                    {
                        return i;
                    }
                }

                return -1;
            }

            // comparison stops at null terminator, terminator parameter, or end-of-block -- whichever comes first.
            [Op]
            public bool Utf8NullTerminatedEquals(int offset, string text, MetadataStringDecoder utf8Decoder, char terminator, bool ignoreCase)
            {
                int firstDifference;
                FastComparisonResult result = Utf8NullTerminatedFastCompare(offset, text, 0, out firstDifference, terminator, ignoreCase);

                if (result == FastComparisonResult.Inconclusive)
                {
                    int bytesRead;
                    string decoded = PeekUtf8NullTerminated(offset, null, utf8Decoder, out bytesRead, terminator);
                    return decoded.Equals(text, ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);
                }

                return result == FastComparisonResult.Equal;
            }

            // comparison stops at null terminator, terminator parameter, or end-of-block -- whichever comes first.
            public bool Utf8NullTerminatedStartsWith(int offset, string text, MetadataStringDecoder utf8Decoder, char terminator, bool ignoreCase)
            {
                int endIndex;
                FastComparisonResult result = Utf8NullTerminatedFastCompare(offset, text, 0, out endIndex, terminator, ignoreCase);

                switch (result)
                {
                    case FastComparisonResult.Equal:
                    case FastComparisonResult.BytesStartWithText:
                        return true;

                    case FastComparisonResult.Unequal:
                    case FastComparisonResult.TextStartsWithBytes:
                        return false;

                    default:
                        Debug.Assert(result == FastComparisonResult.Inconclusive);
                        int bytesRead;
                        string decoded = PeekUtf8NullTerminated(offset, null, utf8Decoder, out bytesRead, terminator);
                        return decoded.StartsWith(text, ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);
                }
            }

            public enum FastComparisonResult
            {
                Equal,

                BytesStartWithText,

                TextStartsWithBytes,

                Unequal,

                Inconclusive
            }

            // comparison stops at null terminator, terminator parameter, or end-of-block -- whichever comes first.
            [Op]
            public FastComparisonResult Utf8NullTerminatedFastCompare(int offset, string text, int textStart, out int firstDifferenceIndex, char terminator, bool ignoreCase)
            {
                Available(offset, 0);

                Debug.Assert(terminator <= 0x7F);

                byte* startPointer = Pointer + offset;
                byte* endPointer = Pointer + Length;
                byte* currentPointer = startPointer;

                int ignoreCaseMask = StringUtils.IgnoreCaseMask(ignoreCase);
                int currentIndex = textStart;
                while (currentIndex < text.Length && currentPointer != endPointer)
                {
                    byte currentByte = *currentPointer;

                    // note that terminator is not compared case-insensitively even if ignore case is true
                    if (currentByte == 0 || currentByte == terminator)
                    {
                        break;
                    }

                    char currentChar = text[currentIndex];
                    if ((currentByte & 0x80) == 0 && StringUtils.IsEqualAscii(currentChar, currentByte, ignoreCaseMask))
                    {
                        currentIndex++;
                        currentPointer++;
                    }
                    else
                    {
                        firstDifferenceIndex = currentIndex;

                        // uncommon non-ascii case --> fall back to slow allocating comparison.
                        return (currentChar > 0x7F) ? FastComparisonResult.Inconclusive : FastComparisonResult.Unequal;
                    }
                }

                firstDifferenceIndex = currentIndex;

                bool textTerminated = currentIndex == text.Length;
                bool bytesTerminated = currentPointer == endPointer || *currentPointer == 0 || *currentPointer == terminator;

                if (textTerminated && bytesTerminated)
                {
                    return FastComparisonResult.Equal;
                }

                return textTerminated ? FastComparisonResult.BytesStartWithText : FastComparisonResult.TextStartsWithBytes;
            }

            // comparison stops at null terminator, terminator parameter, or end-of-block -- whichever comes first.
            [Op]
            public bool Utf8NullTerminatedStringStartsWithAsciiPrefix(int offset, string asciiPrefix)
            {
                // Assumes stringAscii only contains ASCII characters and no nil characters.

                Available(offset, 0);

                // Make sure that we won't read beyond the block even if the block doesn't end with 0 byte.
                if (asciiPrefix.Length > Length - offset)
                {
                    return false;
                }

                byte* p = Pointer + offset;

                for (int i = 0; i < asciiPrefix.Length; i++)
                {
                    Debug.Assert(asciiPrefix[i] > 0 && asciiPrefix[i] <= 0x7f);

                    if (asciiPrefix[i] != *p)
                    {
                        return false;
                    }

                    p++;
                }

                return true;
            }

            public int CompareUtf8NullTerminatedStringWithAsciiString(int offset, string asciiString)
            {
                // Assumes stringAscii only contains ASCII characters and no nil characters.

                Available(offset, 0);

                byte* p = Pointer + offset;
                int limit = Length - offset;

                for (int i = 0; i < asciiString.Length; i++)
                {
                    Debug.Assert(asciiString[i] > 0 && asciiString[i] <= 0x7f);

                    if (i > limit)
                    {
                        // Heap value is shorter.
                        return -1;
                    }

                    if (*p != asciiString[i])
                    {
                        // If we hit the end of the heap value (*p == 0)
                        // the heap value is shorter than the string, so we return negative value.
                        return *p - asciiString[i];
                    }

                    p++;
                }

                // Either the heap value name matches exactly the given string or
                // it is longer so it is considered "greater".
                return (*p == 0) ? 0 : +1;
            }

            [Op]
            public byte[] PeekBytes(int offset, int byteCount)
            {
                Available(offset, byteCount);
                return ReadBytes(Pointer + offset, byteCount);
            }

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

            [Op]
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

            [Op]
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

                Debug.Assert(i == result.Length);
            }

            [Op]
            public bool PeekHeapValueOffsetAndSize(int index, out int offset, out int size)
            {
                int bytesRead;
                int numberOfBytes = PeekCompressedInteger(index, out bytesRead);
                if (numberOfBytes == InvalidCompressedInteger)
                {
                    offset = 0;
                    size = 0;
                    return false;
                }

                offset = index + bytesRead;
                size = numberOfBytes;
                return true;
            }
        }
    }
}