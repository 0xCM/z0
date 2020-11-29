//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;

    using api = TextEncoders;

    public readonly unsafe struct TextCoder : ITextCoder<TextCoder>
    {
        readonly Encoding Encoding;

        [MethodImpl(Inline)]
        internal TextCoder(Encoding service)
            => Encoding = service;

        public string EncodingName
        {
            [MethodImpl(Inline)]
            get => Encoding.EncodingName;
        }

        public int CodePage
        {
            [MethodImpl(Inline)]
            get => Encoding.CodePage;
        }

        public ReadOnlySpan<byte> Preamble
        {
            [MethodImpl(Inline)]
            get => Encoding.Preamble;
        }

        public int WindowsCodePage
        {
            [MethodImpl(Inline)]
            get => Encoding.WindowsCodePage;
        }

        public string WebName
        {
            [MethodImpl(Inline)]
            get => Encoding.WebName;
        }

        [MethodImpl(Inline)]
        public ByteSize Encode(ReadOnlySpan<char> src, Span<byte> dst)
            => Encoding.GetBytes(src,dst);

        [MethodImpl(Inline)]
        public ByteSize EncodedSize(ReadOnlySpan<char> src)
            => Encoding.GetByteCount(src);

        [MethodImpl(Inline)]
        public void Decode(ReadOnlySpan<byte> src, Span<char> dst)
            => Encoding.GetChars(src,dst);

        [MethodImpl(Inline)]
        public ref string Decode(ReadOnlySpan<byte> src, out string dst)
            => ref api.Decode(Encoding, src, out dst);

        [MethodImpl(Inline)]
        public int GetCharCount(ReadOnlySpan<byte> bytes)
            => api.GetCharCount(Encoding, bytes);

        [MethodImpl(Inline)]
        public int GetCharCount(byte* bytes, int count)
            => api.GetCharCount(Encoding, bytes,count);

        [MethodImpl(Inline)]
        public char[] GetChars(byte[] bytes)
            => api.GetChars(Encoding, bytes);

        [MethodImpl(Inline)]
        public int GetChars(byte* bytes, int byteCount, char* chars, int charCount)
            => api.GetChars(Encoding, bytes, byteCount, chars, charCount);

        [MethodImpl(Inline)]
        public void GetChars(ReadOnlySpan<byte> src, Span<char> dst)
            => api.GetChars(Encoding, src,dst);

        [MethodImpl(Inline)]
        public int GetByteCount(ReadOnlySpan<char> src)
            => Encoding.GetByteCount(src);

        [MethodImpl(Inline)]
        public int GetByteCount(string src)
            => api.GetByteCount(Encoding, src);

        [MethodImpl(Inline)]
        public int GetByteCount(string src, int index, int count)
            => api.GetByteCount(Encoding, src, index, count);

        [MethodImpl(Inline)]
        public int GetByteCount(char* src, int count)
            => api.GetByteCount(Encoding, src, count);

        [MethodImpl(Inline)]
        public byte[] GetBytes(string src)
            => api.GetBytes(Encoding, src);

        [MethodImpl(Inline)]
        public int GetBytes(ReadOnlySpan<char> src, Span<byte> dst)
            => api.GetBytes(Encoding, src, dst);

        [MethodImpl(Inline)]
        public byte[] GetBytes(char[] src)
            => api.GetBytes(Encoding, src);

        [MethodImpl(Inline)]
        public int GetBytes(char* src, int charCount, byte* bytes, int byteCount)
            => api.GetBytes(Encoding, src, charCount, bytes, byteCount);

        [MethodImpl(Inline)]
        public string GetString(byte[] src)
            => api.GetString(Encoding, src);

        [MethodImpl(Inline)]
        public string GetString(ReadOnlySpan<byte> src)
            => api.GetString(Encoding, src);

        [MethodImpl(Inline)]
        public string GetString(byte* src, int byteCount)
            => api.GetString(Encoding, src, byteCount);

        [MethodImpl(Inline)]
        public string GetString(byte[] src, int index, int count)
            => api.GetString(Encoding, src, index, count);
    }
}