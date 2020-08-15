//-----------------------------------------------------------------------------
// Copyright   :  Microsoft
// License     : MIT via .Net Foundation
// Extracted from System.Reflection.MetadataReader library code
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    internal static class StringUtils
    {
        internal static int IgnoreCaseMask(bool ignoreCase)
        {
            return ignoreCase ? 0x20 : 0xff;
        }

        internal static bool IsEqualAscii(int a, int b, int ignoreCaseMask)
        {
            // When not ignoring case (most often):
            // - only the first condition is evaluated multiple times during the loop.
            // - the remaining condition is false since ignoreCaseMask is 0xff.
            // When ignoring case
            // - the most likely case is still a == b
            // - ignoreCaseMask is 0x20
            return a == b || ((a | 0x20) == (b | 0x20) && unchecked((uint)((a | ignoreCaseMask) - 'a')) <= 'z' - 'a');
        }
    }

    internal static unsafe class BlobUtilities
    {
        public static byte[] ReadBytes(byte* buffer, int byteCount)
        {
            if (byteCount == 0)
                return array<byte>();

            byte[] result = new byte[byteCount];
            Marshal.Copy((IntPtr)buffer, result, 0, byteCount);
            return result;
        }

        public static void WriteUTF8(this byte[] buffer, int start, char* charPtr, int charCount, int byteCount, bool allowUnpairedSurrogates)
        {
            Debug.Assert(byteCount >= charCount);
            const char ReplacementCharacter = '\uFFFD';

            char* strEnd = charPtr + charCount;
            fixed (byte* bufferPtr = &buffer[0])
            {
                byte* ptr = bufferPtr + start;

                if (byteCount == charCount)
                {
                    while (charPtr < strEnd)
                    {
                        Debug.Assert(*charPtr <= 0x7f);
                        *ptr++ = unchecked((byte)*charPtr++);
                    }
                }
                else
                {
                    while (charPtr < strEnd)
                    {
                        char c = *charPtr++;

                        if (c < 0x80)
                        {
                            *ptr++ = (byte)c;
                            continue;
                        }

                        if (c < 0x800)
                        {
                            ptr[0] = (byte)(((c >> 6) & 0x1F) | 0xC0);
                            ptr[1] = (byte)((c & 0x3F) | 0x80);
                            ptr += 2;
                            continue;
                        }

                        if (IsSurrogateChar(c))
                        {
                            // surrogate pair
                            if (IsHighSurrogateChar(c) && charPtr < strEnd && IsLowSurrogateChar(*charPtr))
                            {
                                int highSurrogate = c;
                                int lowSurrogate = *charPtr++;
                                int codepoint = (((highSurrogate - 0xd800) << 10) + lowSurrogate - 0xdc00) + 0x10000;
                                ptr[0] = (byte)(((codepoint >> 18) & 0x7) | 0xF0);
                                ptr[1] = (byte)(((codepoint >> 12) & 0x3F) | 0x80);
                                ptr[2] = (byte)(((codepoint >> 6) & 0x3F) | 0x80);
                                ptr[3] = (byte)((codepoint & 0x3F) | 0x80);
                                ptr += 4;
                                continue;
                            }

                            // unpaired high/low surrogate
                            if (!allowUnpairedSurrogates)
                            {
                                c = ReplacementCharacter;
                            }
                        }

                        ptr[0] = (byte)(((c >> 12) & 0xF) | 0xE0);
                        ptr[1] = (byte)(((c >> 6) & 0x3F) | 0x80);
                        ptr[2] = (byte)((c & 0x3F) | 0x80);
                        ptr += 3;
                    }
                }

                Debug.Assert(ptr == bufferPtr + start + byteCount);
                Debug.Assert(charPtr == strEnd);
            }
        }

        internal static unsafe int GetUTF8ByteCount(string str)
        {
            fixed (char* ptr = str)
            {
                return GetUTF8ByteCount(ptr, str.Length);
            }
        }

        internal static unsafe int GetUTF8ByteCount(char* str, int charCount)
        {
            char* remainder;
            return GetUTF8ByteCount(str, charCount, int.MaxValue, out remainder);
        }

        internal static int GetUTF8ByteCount(char* str, int charCount, int byteLimit, out char* remainder)
        {
            char* end = str + charCount;

            char* ptr = str;
            int byteCount = 0;
            while (ptr < end)
            {
                int characterSize;
                char c = *ptr++;
                if (c < 0x80)
                {
                    characterSize = 1;
                }
                else if (c < 0x800)
                {
                    characterSize = 2;
                }
                else if (IsHighSurrogateChar(c) && ptr < end && IsLowSurrogateChar(*ptr))
                {
                    // surrogate pair:
                    characterSize = 4;
                    ptr++;
                }
                else
                {
                    characterSize = 3;
                }

                if (byteCount + characterSize > byteLimit)
                {
                    ptr -= (characterSize < 4) ? 1 : 2;
                    break;
                }

                byteCount += characterSize;
            }

            remainder = ptr;
            return byteCount;
        }

        internal static bool IsSurrogateChar(int c)
        {
            return unchecked((uint)(c - 0xD800)) <= 0xDFFF - 0xD800;
        }

        internal static bool IsHighSurrogateChar(int c)
        {
            return unchecked((uint)(c - 0xD800)) <= 0xDBFF - 0xD800;
        }

        internal static bool IsLowSurrogateChar(int c)
        {
            return unchecked((uint)(c - 0xDC00)) <= 0xDFFF - 0xDC00;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void ValidateRange(int bufferLength, int start, int byteCount, string byteCountParameterName)
        {
            if (start < 0 || start > bufferLength)
            {
                sys.@throw(new ArgumentOutOfRangeException(nameof(start)));
            }

            if (byteCount < 0 || byteCount > bufferLength - start)
            {
                sys.@throw(new ArgumentOutOfRangeException(byteCountParameterName));
            }
        }

        internal static int GetUserStringByteLength(int characterCount)
        {
            return characterCount * 2 + 1;
        }

        internal static byte GetUserStringTrailingByte(string str)
        {
            // ECMA-335 II.24.2.4:
            // This final byte holds the value 1 if and only if any UTF16 character within
            // the string has any bit set in its top byte, or its low byte is any of the following:
            // 0x01-0x08, 0x0E-0x1F, 0x27, 0x2D, 0x7F.  Otherwise, it holds 0.
            // The 1 signifies Unicode characters that require handling beyond that normally provided for 8-bit encoding sets.

            foreach (char ch in str)
            {
                if (ch >= 0x7F)
                {
                    return 1;
                }

                switch ((int)ch)
                {
                    case 0x1:
                    case 0x2:
                    case 0x3:
                    case 0x4:
                    case 0x5:
                    case 0x6:
                    case 0x7:
                    case 0x8:
                    case 0xE:
                    case 0xF:
                    case 0x10:
                    case 0x11:
                    case 0x12:
                    case 0x13:
                    case 0x14:
                    case 0x15:
                    case 0x16:
                    case 0x17:
                    case 0x18:
                    case 0x19:
                    case 0x1A:
                    case 0x1B:
                    case 0x1C:
                    case 0x1D:
                    case 0x1E:
                    case 0x1F:
                    case 0x27:
                    case 0x2D:
                        return 1;
                }
            }

            return 0;
        }
    }
}