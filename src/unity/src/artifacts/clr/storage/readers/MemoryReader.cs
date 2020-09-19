#define LITTLEENDIAN
//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;

    using System.Runtime.InteropServices;

    using static Konst;

    using static ClrStorage;

    partial struct ClrStorageReaders
    {

        unsafe internal struct MemoryReader
        {
            //^ [SpecPublic]
            readonly byte* Buffer;

            //^ [SpecPublic]
            byte* CurrentPointer;

            internal readonly int Length;
            // ^ invariant this.CurrentPointer >= this.Buffer;
            // ^ invariant this.CurrentPointer <= this.Buffer + this.Length;
            // ^ invariant this.Length > 0;
            // ^ invariant this.Buffer != null;
            // ^ invariant this.CurrentPointer != null;


            //^ requires buffer != null;
            //^ requires offset <= length;
            //^ requires length > 0;
            internal MemoryReader(byte* buffer, int length, int offset)
            {
                if (offset > length)
                    throw new ArgumentOutOfRangeException();
                this.Buffer = buffer;
                this.CurrentPointer = buffer + offset;
                this.Length = length;
            }

            //^ requires buffer != null;
            //^ requires length > 0;
            internal MemoryReader(byte* buffer, int length)
                : this(buffer, length, 0)
            {
            }

            //^ requires buffer != null;
            //^ requires length > 0;
            internal MemoryReader(byte* buffer, uint length)
            : this(buffer, (int)length, 0)
            {
            }

            //^ requires memBlock.IsValid;
            internal MemoryReader(MemoryBlock memBlock)
                : this(memBlock.Buffer, memBlock.Length, 0)
            {

            }

            internal uint Offset
            {
                get
                {
                    return (uint)checked(this.CurrentPointer - this.Buffer);
                }
            }

            internal uint RemainingBytes
            {
                get
                {
                    return (uint)checked(this.Length - (this.CurrentPointer - this.Buffer));
                }
            }

            internal bool NotEndOfBytes
            {
                get
                {
                    return this.Length > (int)checked(this.CurrentPointer - this.Buffer);
                }
            }

            internal bool SeekOffset(int offset)
            {
                if (offset >= this.Length)
                    return false;
                CurrentPointer = Buffer + offset;
                return true;
            }

            internal void SkipBytes(int count)
            {
                if (checked(this.CurrentPointer - this.Buffer + count) > this.Length)
                    throw new ArgumentOutOfRangeException();
                this.CurrentPointer = this.CurrentPointer + count;
            }

            //^ requires alignment == 2 || alignment == 4 || alignment == 8 || alignment == 16 || alignment == 32 || alignment == 64;
            internal void Align(uint alignment)
            {
                uint remainder = this.Offset & (alignment - 1);
                if (remainder != 0)
                {
                    if (checked(this.CurrentPointer - this.Buffer + alignment - remainder) > this.Length)
                    throw new ArgumentOutOfRangeException();
                    this.CurrentPointer += alignment - remainder;
                }
            }

            internal MemoryBlock RemainingMemoryBlock
                => new MemoryBlock(CurrentPointer, RemainingBytes);

            //^ requires this.CurrentPointer - this.Buffer + offset + length <= this.Length;
            internal MemoryBlock GetMemoryBlockAt(uint offset, uint length)
            {
                if (checked(this.CurrentPointer - this.Buffer + offset + length) > this.Length)
                    throw new ArgumentOutOfRangeException();

                return new MemoryBlock(this.CurrentPointer + offset, length);
            }

            //^ requires this.CurrentPointer - this.Buffer + offset + length <= this.Length;
            internal MemoryBlock GetMemoryBlockAt(int offset,int length)
            {
                if (checked(this.CurrentPointer - this.Buffer + offset + length) > this.Length)
                throw new ArgumentOutOfRangeException();
                return new MemoryBlock(this.CurrentPointer + offset, length);
            }

            internal Int16 PeekInt16(int offset)
            {
                if (checked(this.CurrentPointer - this.Buffer + offset + sizeof(Int16)) > this.Length)
                    throw new ArgumentOutOfRangeException();
                return *(Int16*)(this.CurrentPointer + offset);
            }

            internal Int32 PeekInt32(int offset)
            {
                if (checked(this.CurrentPointer - this.Buffer + offset + sizeof(Int32)) > this.Length)
                    throw new ArgumentOutOfRangeException();
                return *(Int32*)(this.CurrentPointer + offset);
            }

            internal Byte PeekByte(int offset)
            {
                if (checked(this.CurrentPointer - this.Buffer + offset) > this.Length)
                throw new ArgumentOutOfRangeException();
                return *(Byte*)(this.CurrentPointer + offset);
            }

            internal UInt16 PeekUInt16(int offset)
            {
                if (checked(this.CurrentPointer - this.Buffer + offset + sizeof(UInt16)) > this.Length)
                    throw new ArgumentOutOfRangeException();
                return *(UInt16*)(this.CurrentPointer + offset);
            }

            internal UInt16 PeekUInt16(uint offset)
            {
                if (checked(this.CurrentPointer - this.Buffer + offset + sizeof(UInt16)) > this.Length)
                    throw new ArgumentOutOfRangeException();
                return *(UInt16*)(this.CurrentPointer + offset);
            }

            internal UInt32 PeekUInt32(int offset)
            {
                if (checked(this.CurrentPointer - this.Buffer + offset + sizeof(UInt32)) > this.Length)
                    throw new ArgumentOutOfRangeException();
                return *(UInt32*)(this.CurrentPointer + offset);
            }

            internal UInt32 PeekUInt32(uint offset)
            {
                if (checked(this.CurrentPointer - this.Buffer + offset + sizeof(UInt32)) > this.Length)
                    throw new ArgumentOutOfRangeException();
                return *(UInt32*)(this.CurrentPointer + offset);
            }

            internal UInt32 PeekReference(int offset, bool smallRefSize)
            {
                if (smallRefSize)
                    return PeekUInt16(offset);
                return PeekUInt32(offset);
            }

            internal UInt32 PeekReference(uint offset, bool smallRefSize)
            {
                if (smallRefSize)
                    return PeekUInt16(offset);
                return PeekUInt32(offset);
            }

            internal Guid PeekGuid(int offset)
            {
                if (checked(this.CurrentPointer - this.Buffer + offset + sizeof(Guid)) > this.Length)
                    throw new ArgumentOutOfRangeException();
                return *(Guid*)(this.CurrentPointer + offset);
            }

            internal byte[] PeekBytes(int offset,int byteCount)
            {
                if (checked(this.CurrentPointer - this.Buffer + offset + byteCount) > this.Length)
                    throw new ArgumentOutOfRangeException();
                byte[] result = new byte[byteCount];
                byte* pIter = this.CurrentPointer + offset;
                byte* pEnd = pIter + byteCount;
                fixed (byte* pResult = result) {
                    byte* resultIter = pResult;
                    while (pIter < pEnd) {
                    *resultIter = *pIter;
                    pIter++;
                    resultIter++;
                    }
                }
                return result;
            }

            private static string ScanUTF16WithSize(byte* bytePtr, int byteCount)
            {
                var charsToRead = byteCount / sizeof(Char);
                char* pc = (char*)bytePtr;
                return new String(pc, 0, charsToRead);
            }

            internal string PeekUTF16WithSize(int offset, int byteCount)
            {
                if (checked(this.CurrentPointer - this.Buffer + offset + byteCount) > this.Length)
                    throw new ArgumentOutOfRangeException();

                    return MemoryReader.ScanUTF16WithSize(this.CurrentPointer + offset, byteCount);
            }

            internal int PeekCompressedInt32(int offset, out int numberOfBytesRead)
            {

                var headerByte = this.PeekByte(offset);
                int result;
                if ((headerByte & 0x80) == 0x00) {
                    result = headerByte;
                    numberOfBytesRead = 1;
                } else if ((headerByte & 0x40) == 0x00) {
                    result = ((headerByte & 0x3f) << 8) | this.PeekByte(offset + 1);
                    numberOfBytesRead = 2;
                } else if (headerByte == 0xFF) {
                    result = -1;
                    numberOfBytesRead = 1;
                } else {
                    int offsetIter = offset + 1;
                    result = ((headerByte & 0x3f) << 24) | (this.PeekByte(offsetIter) << 16);
                    offsetIter++;
                    result |= (this.PeekByte(offsetIter) << 8);
                    offsetIter++;
                    result |= this.PeekByte(offsetIter);
                    numberOfBytesRead = 4;
                }
                return result;
            }

            internal uint PeekCompressedUInt32(uint offset, out uint numberOfBytesRead)
            {
                var headerByte = this.PeekByte((int)offset);
                var result = 0u;
                if ((headerByte & 0x80) == 0x00)
                {
                    result = headerByte;
                    numberOfBytesRead = 1;
                }
                else if ((headerByte & 0x40) == 0x00) {
                    result = (uint)((headerByte & 0x3f) << 8) | this.PeekByte((int)offset + 1);
                    numberOfBytesRead = 2;
                }
                else if (headerByte == 0xFF) {
                    result = 0xFF;
                    numberOfBytesRead = 1;
                }
                else
                {
                    int offsetIter = (int)offset + 1;
                    result = (uint)((headerByte & 0x3f) << 24) | (uint)(this.PeekByte(offsetIter) << 16);
                    offsetIter++;
                    result |= (uint)(PeekByte(offsetIter) << 8);
                    offsetIter++;
                    result |= (uint)PeekByte(offsetIter);
                    numberOfBytesRead = 4;
                }
                return result;
            }

            internal string PeekUTF8NullTerminated(int offset, out int numberOfBytesRead)
            {
                if (checked(this.CurrentPointer - this.Buffer + offset) >= this.Length)
                { numberOfBytesRead = 0; return ""; }
                byte* pStart = this.CurrentPointer + offset;
                byte* pEnd = this.Buffer+this.Length;
                byte* pIter = pStart;
                StringBuilder sb = StringBuilderCache.Acquire();
                byte b = 0;
                for (; ; ) {
                    b = *pIter++;
                    if (b == 0 || pIter == pEnd) break;
                    if ((b & 0x80) == 0) {
                    sb.Append((char)b);
                    continue;
                    }
                    char ch;
                    byte b1 = *pIter++;
                    if (b1 == 0 || pIter == pEnd) { //Dangling lead byte, do not decompose
                    sb.Append((char)b);
                    break;
                    }
                    if ((b & 0x20) == 0) {
                    ch = (char)(((b & 0x1F) << 6) | (b1 & 0x3F));
                    } else {
                    byte b2 = *pIter++;
                    if (b2 == 0 || pIter == pEnd) { //Dangling lead bytes, do not decompose
                        sb.Append((char)((b << 8) | b1));
                        break;
                    }
                    uint ch32;
                    if ((b & 0x10) == 0)
                        ch32 = (uint)(((b & 0x0F) << 12) | ((b1 & 0x3F) << 6) | (b2 & 0x3F));
                    else {
                        byte b3 = *pIter++;
                        if (b3 == 0 || pIter == pEnd) { //Dangling lead bytes, do not decompose
                        sb.Append((char)((b << 8) | b1));
                        sb.Append((char)b2);
                        break;
                        }
                        ch32 = (uint)(((b & 0x07) << 18) | ((b1 & 0x3F) << 12) | ((b2 & 0x3F) << 6) | (b3 & 0x3F));
                    }
                    if ((ch32 & 0xFFFF0000) == 0)
                        ch = (char)ch32;
                    else { //break up into UTF16 surrogate pair
                        ch32 -= 0x10000;
                        sb.Append((char)((ch32 >> 10) | 0xD800));
                        ch = (char)((ch32 & 0x3FF) | 0xDC00);
                    }
                    }
                    sb.Append(ch);
                }
                numberOfBytesRead = (int)(pIter - pStart);
                return StringBuilderCache.GetStringAndRelease(sb);
            }

            internal string PeekUTF16WithShortSize(int offset,out int numberOfBytesRead)
            {
            int length = this.PeekUInt16(offset);
            if (checked(this.CurrentPointer - this.Buffer + offset + sizeof(UInt16) + length * sizeof(Char)) > this.Length)
                throw new ArgumentOutOfRangeException();

        #if !COMPACTFX && !__MonoCS__
        #if LITTLEENDIAN
            string result = new string((char*)(this.CurrentPointer + offset + sizeof(UInt16)), 0, length);
        #elif BIGENDIAN
            string result = new string((sbyte*)(this.CurrentPointer + offset + sizeof(UInt16)), 0, length * sizeof(Char), Encoding.Unicode);
        #endif
        #else
            string result = MemoryReader.ScanUTF16WithSize(this.CurrentPointer + offset + sizeof(UInt16), length * sizeof(Char));
        #endif
            numberOfBytesRead = sizeof(UInt16) + result.Length * sizeof(Char);
            return result;
            }

            //  Always RowNumber....
            internal int BinarySearchForSlot(uint numberOfRows, int rowSize, int referenceOffset, uint referenceValue, bool isReferenceSmall)
            {
                var startRowNumber = 0;
                var endRowNumber = (int)numberOfRows - 1;
                var startValue = this.PeekReference(startRowNumber * rowSize + referenceOffset, isReferenceSmall);
                var endValue = this.PeekReference(endRowNumber * rowSize + referenceOffset, isReferenceSmall);
                if (endRowNumber == 1)
                {
                    if (referenceValue >= endValue) return endRowNumber;
                    return startRowNumber;
                }
                while ((endRowNumber - startRowNumber) > 1)
                {
                    if (referenceValue <= startValue)
                        return referenceValue == startValue ? startRowNumber : startRowNumber - 1;
                    else if (referenceValue >= endValue)
                        return referenceValue == endValue ? endRowNumber : endRowNumber + 1;

                    var midRowNumber = (startRowNumber + endRowNumber) / 2;
                    var midReferenceValue = PeekReference(midRowNumber * rowSize + referenceOffset, isReferenceSmall);
                    if (referenceValue > midReferenceValue)
                    {
                        startRowNumber = midRowNumber;
                        startValue = midReferenceValue;
                    }
                    else if(referenceValue < midReferenceValue)
                    {
                        endRowNumber = midRowNumber;
                        endValue = midReferenceValue;
                    }
                    else
                        return midRowNumber;
                }
                return startRowNumber;
            }

            //  Always RowNumber....
            internal int BinarySearchReference(uint numberOfRows, int rowSize, int referenceOffset, uint referenceValue, bool isReferenceSmall)
            {
                int startRowNumber = 0;
                int endRowNumber = (int)numberOfRows - 1;
                while (startRowNumber <= endRowNumber) {
                    int midRowNumber = (startRowNumber + endRowNumber) / 2;
                    uint midReferenceValue = this.PeekReference(midRowNumber * rowSize + referenceOffset, isReferenceSmall);
                    if (referenceValue > midReferenceValue)
                    startRowNumber = midRowNumber + 1;
                    else if (referenceValue < midReferenceValue)
                    endRowNumber = midRowNumber - 1;
                    else
                    return midRowNumber;
                }
                return NotFound;
            }

            //  Always RowNumber....
            internal int LinearSearchReference(int rowSize, int referenceOffset, uint referenceValue, bool isReferenceSmall)
            {
                var currOffset = referenceOffset;
                var totalSize = Length;
                while (currOffset < totalSize)
                {
                    uint currReference = PeekReference(currOffset, isReferenceSmall);
                    if (currReference == referenceValue)
                        return currOffset / rowSize;

                    currOffset += rowSize;
                }
                return -1;
            }


            internal Char ReadChar()
            {
                if (checked(this.CurrentPointer - this.Buffer + sizeof(Char)) > this.Length)
                    throw new ArgumentOutOfRangeException();

                byte* pb = this.CurrentPointer;
                Char v = *(Char*)pb;
                this.CurrentPointer = pb + sizeof(Char);
                return v;
            }

            internal sbyte ReadSByte()
            {
                if (checked(this.CurrentPointer - this.Buffer + sizeof(SByte)) > this.Length)
                    throw new ArgumentOutOfRangeException();

                byte* pb = this.CurrentPointer;
                SByte v = *(SByte*)pb;
                this.CurrentPointer = pb + sizeof(SByte);
                return v;
            }

            internal short ReadInt16()
            {
                if (checked(this.CurrentPointer - this.Buffer + sizeof(Int16)) > this.Length)
                    throw new ArgumentOutOfRangeException();

                var pb = CurrentPointer;
                var v = *(Int16*)pb;
                CurrentPointer = pb + sizeof(Int16);
                return v;
            }

            internal int ReadInt32() {
            if (checked(this.CurrentPointer - this.Buffer + sizeof(Int32)) > this.Length)
                throw new ArgumentOutOfRangeException();

            byte* pb = this.CurrentPointer;
            Int32 v = *(Int32*)pb;
            this.CurrentPointer = pb + sizeof(Int32);
            return v;
            }

            internal long ReadInt64()
            {
                if (checked(this.CurrentPointer - this.Buffer + sizeof(Int64)) > this.Length)
                    throw new ArgumentOutOfRangeException();

                byte* pb = this.CurrentPointer;
                var v = *(Int64*)pb;
                CurrentPointer = pb + sizeof(Int64);
                return v;
            }

            internal byte ReadByte()
            {
                if (checked(this.CurrentPointer - this.Buffer + sizeof(Byte)) > this.Length)
                    throw new ArgumentOutOfRangeException();

                var pb = CurrentPointer;
                var v = *(Byte*)pb;
                CurrentPointer = pb + sizeof(Byte);
                return v;
            }

            internal ushort ReadUInt16()
            {
                if (checked(this.CurrentPointer - this.Buffer + sizeof(UInt16)) > this.Length)
                    throw new ArgumentOutOfRangeException();

                var pb = this.CurrentPointer;
                var v = *(UInt16*)pb;
                CurrentPointer = pb + sizeof(UInt16);
                return v;
            }

            internal uint ReadUInt32()
            {
                if (checked(this.CurrentPointer - this.Buffer + sizeof(UInt32)) > this.Length)
                    throw new ArgumentOutOfRangeException();

                var pb = this.CurrentPointer;
                var v = *(UInt32*)pb;
                CurrentPointer = pb + sizeof(UInt32);
                return v;
            }

            internal ulong ReadUInt64()
            {
                if (checked(this.CurrentPointer - this.Buffer + sizeof(UInt64)) > this.Length)
                    throw new ArgumentOutOfRangeException();

                var pb = this.CurrentPointer;
                var v = *(UInt64*)pb;
                CurrentPointer = pb + sizeof(UInt64);
                return v;
            }

            internal float ReadSingle()
            {
                if (checked(this.CurrentPointer - this.Buffer + sizeof(Single)) > this.Length)
                    throw new ArgumentOutOfRangeException();

                byte* pb = this.CurrentPointer;
                Single v = *(Single*)pb;
                this.CurrentPointer = pb + sizeof(Single);
                return v;
            }

            internal double ReadDouble()
            {
                if (checked(this.CurrentPointer - this.Buffer + sizeof(Double)) > this.Length)
                    throw new ArgumentOutOfRangeException();

                byte* pb = CurrentPointer;
                var v = *(Double*)pb;
                CurrentPointer = pb + sizeof(Double);
                return v;
            }

            internal OperationCode ReadOpcode()
            {
                int result = this.ReadByte();
                if (result == 0xFE)
                    result = result << 8 | this.ReadByte();
                return (OperationCode)result;
            }

                internal string ReadASCIIWithSize(int byteCount)
                {
                    if (checked(this.CurrentPointer - this.Buffer + byteCount) > this.Length)
                        throw new ArgumentOutOfRangeException();
        #if HOST_CORERT || NO_STRING_CTOR_FROM_PTR_AND_ENCODING
                var pb = CurrentPointer;
                var buffer = new char[byteCount];
                int j = 0;
                fixed (char* uBuffer = buffer)
                {
                    char* iterBuffer = uBuffer;
                    char* endBuffer = uBuffer + byteCount;
                    while (iterBuffer < endBuffer)
                    {
                        byte b = *pb++;
                        if (b == 0)
                            break;
                        *iterBuffer++ = (char)b;
                        j++;
                    }
                }
                this.CurrentPointer += byteCount;
                return new string(buffer, 0, j);
        #else
                    sbyte* pStart = (sbyte*)this.CurrentPointer;
                    sbyte* pEnd = pStart + byteCount;
                    sbyte* pIter = pStart;
                    while (*pIter != '\0' && pIter < pEnd)
                        pIter++;
                    int cbString = (int)(pIter - pStart);
                    string retStr = new string(pStart, 0, cbString, Encoding.ASCII);
                    this.CurrentPointer += byteCount;
                    return retStr;
        #endif
                }

                internal string ReadUTF8WithSize(int byteCount)
            {
            if (checked(this.CurrentPointer - this.Buffer + byteCount) > this.Length)
                throw new ArgumentOutOfRangeException();

            int bytesToRead = byteCount;
            StringBuilder buffer = StringBuilderCache.Acquire();
            byte* pb = this.CurrentPointer;
            while (bytesToRead > 0) {
                byte b = *pb++; bytesToRead--;
                if ((b & 0x80) == 0 || bytesToRead == 0) {
                buffer.Append((char)b);
                continue;
                }
                char ch;
                byte b1 = *pb++; bytesToRead--;
                if ((b & 0x20) == 0)
                ch = (char)(((b & 0x1F) << 6) | (b1 & 0x3F));
                else {
                if (bytesToRead == 0) { //Dangling lead bytes, do not decompose
                    buffer.Append((char)((b << 8) | b1));
                    break;
                }
                byte b2 = *pb++; bytesToRead--;
                uint ch32;
                if ((b & 0x10) == 0)
                    ch32 = (uint)(((b & 0x0F) << 12) | ((b1 & 0x3F) << 6) | (b2 & 0x3F));
                else {
                    if (bytesToRead == 0) { //Dangling lead bytes, do not decompose
                    buffer.Append((char)((b << 8) | b1));
                    buffer.Append((char)b2);
                    break;
                    }
                    byte b3 = *pb++; bytesToRead--;
                    ch32 = (uint)(((b & 0x07) << 18) | ((b1 & 0x3F) << 12) | ((b2 & 0x3F) << 6) | (b3 & 0x3F));
                }
                if ((ch32 & 0xFFFF0000) == 0)
                    ch = (char)ch32;
                else { //break up into UTF16 surrogate pair
                    ch32 -= 0x10000;
                    buffer.Append((char)((ch32 >> 10) | 0xD800));
                    ch = (char)((ch32 & 0x3FF) | 0xDC00);
                }
                }
                buffer.Append(ch);
            }
            CurrentPointer += byteCount;
            return StringBuilderCache.GetStringAndRelease(buffer);
            }

            internal string ReadUTF16WithSize(int byteCount)
            {
                if (checked(this.CurrentPointer - this.Buffer + byteCount) > this.Length)
                    throw new ArgumentOutOfRangeException();
                string retString = MemoryReader.ScanUTF16WithSize(this.CurrentPointer, byteCount);
                this.CurrentPointer += byteCount;
                return retString;
            }

            /// <summary>
            /// Returns -1 if the first byte is 0xFF. This is used to represent the index for the null string.
            /// </summary>
            internal int ReadCompressedUInt32()
            {
                byte headerByte = this.ReadByte();
                int result;
                if ((headerByte & 0x80) == 0x00)
                    result = headerByte;
                else if ((headerByte & 0x40) == 0x00)
                    result = ((headerByte & 0x3f) << 8) | this.ReadByte();
                else if (headerByte == 0xFF)
                    result = -1;
                else
                    result = ((headerByte & 0x3f) << 24) | (this.ReadByte() << 16) | (this.ReadByte() << 8) | this.ReadByte();
                return result;
            }

            internal int ReadCompressedInt32()
            {
                byte headerByte = this.ReadByte();
                int result;
                if ((headerByte & 0x80) == 0x00) {
                    result = headerByte;
                    if ((result & 0x01) == 0)
                    result = result >> 1;
                    else
                    result = (result >> 1) - 0x40;
                } else if ((headerByte & 0x40) == 0x00) {
                    result = ((headerByte & 0x3f) << 8) | this.ReadByte();
                    if ((result & 0x01) == 0)
                    result = result >> 1;
                    else
                    result = (result >> 1) - 0x2000;
                } else if (headerByte == 0xFF)
                    result = -1;
                else {
                    result = ((headerByte & 0x3f) << 24) | (this.ReadByte() << 16) | (this.ReadByte() << 8) | this.ReadByte();
                    if ((result & 0x01) == 0)
                    result = result >> 1;
                    else
                    result = (result >> 1) - 0x20000000;
            }
            return result;
            }

            internal string ReadASCIINullTerminated()
            {
                int count = 128;
                byte* pb = this.CurrentPointer;
                char[] buffer = new char[count];
                int j = 0;
                byte b = 0;
                Restart:
                while (j < count) {
                    if (checked(pb - this.Buffer + 1) > this.Length)
                    throw new ArgumentOutOfRangeException();
                    b = *pb++;
                    if (b == 0) break;
                    buffer[j] = (char)b;
                    j++;
                }
                if (b != 0) {
                    count <<= 2;
                    char[] newBuffer = new char[count];
                    for (int copy = 0; copy < j; copy++)
                    newBuffer[copy] = buffer[copy];
                    buffer = newBuffer;
                    goto Restart;
                }
                this.CurrentPointer = pb;
                return new String(buffer, 0, j);
            }

        }
    }
}