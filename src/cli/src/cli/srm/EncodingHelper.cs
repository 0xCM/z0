//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Buffers;
    using System.Diagnostics;
    using System.Reflection.Metadata;
    using System.Runtime.InteropServices;
    using System;

    partial class SRM
    {
        public static unsafe string decode(byte* bytes, int byteCount, byte[]? prefix, MetadataStringDecoder utf8Decoder)
        {
            if (prefix != null)
                return DecodeUtf8Prefixed(bytes, byteCount, prefix, utf8Decoder);

            if (byteCount == 0)
                return string.Empty;

            return utf8Decoder.GetString(bytes, byteCount);
        }

        unsafe static string DecodeUtf8Prefixed(byte* bytes, int byteCount, byte[] prefix, MetadataStringDecoder utf8Decoder)
        {
            int prefixedByteCount = byteCount + prefix.Length;

            if (prefixedByteCount == 0)
                return string.Empty;

            byte[] buffer = ArrayPool<byte>.Shared.Rent(prefixedByteCount);

            prefix.CopyTo(buffer, 0);
            Marshal.Copy((IntPtr)bytes, buffer, prefix.Length, byteCount);

            string result;
            fixed(byte* prefixedBytes = &buffer[0])
            {
                result = utf8Decoder.GetString(prefixedBytes, prefixedByteCount);
            }

            ArrayPool<byte>.Shared.Return(buffer);
            return result;
        }

        /// <summary>
        /// Provides helpers to decode strings from unmanaged memory to System.String while avoiding
        /// intermediate allocation.
        /// </summary>
        internal static unsafe class EncodingHelper
        {
            public static string DecodeUtf8(byte* bytes, int byteCount, byte[]? prefix, MetadataStringDecoder utf8Decoder)
                => decode(bytes, byteCount, prefix, utf8Decoder);
        }
    }
}