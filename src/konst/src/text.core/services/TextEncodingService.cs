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

    public readonly unsafe struct TextEncodingService : ITextEncoder<TextEncodingService>
    {
        readonly Encoding Effector;

        [MethodImpl(Inline)]
        internal TextEncodingService(Encoding service)
            => Effector = service;

        public string EncodingName
        {
            [MethodImpl(Inline)]
            get => Effector.EncodingName;
        }

        public int CodePage
        {
            [MethodImpl(Inline)]
            get => Effector.CodePage;
        }

        public ReadOnlySpan<byte> Preamble
        {
            [MethodImpl(Inline)]
            get => Effector.Preamble;
        }

        public int WindowsCodePage
        {
            [MethodImpl(Inline)]
            get => Effector.WindowsCodePage;
        }

        public string WebName
        {
            [MethodImpl(Inline)]
            get => Effector.WebName;
        }

        [MethodImpl(Inline)]
        public int GetCharCount(ReadOnlySpan<byte> bytes)
            => Effector.GetCharCount(bytes);

        [MethodImpl(Inline)]
        public int GetCharCount(byte* bytes, int count)
            => Effector.GetCharCount(bytes,count);

        [MethodImpl(Inline)]
        public char[] GetChars(byte[] bytes)
            => Effector.GetChars(bytes);

        [MethodImpl(Inline)]
        public int GetChars(byte* bytes, int byteCount, char* chars, int charCount)
            => Effector.GetChars(bytes,byteCount,chars,charCount);

        [MethodImpl(Inline)]
        public void GetChars(ReadOnlySpan<byte> src, Span<char> dst)
            => Effector.GetChars(src,dst);

        [MethodImpl(Inline)]
        public int GetByteCount(ReadOnlySpan<char> src)
            => Effector.GetByteCount(src);

        [MethodImpl(Inline)]
        public int GetByteCount(string src)
            => Effector.GetByteCount(src);

        [MethodImpl(Inline)]
        public int GetByteCount(string src, int index, int count)
            => Effector.GetByteCount(src, index, count);

        [MethodImpl(Inline)]
        public int GetByteCount(char* src, int count)
            => Effector.GetByteCount(src, count);

        [MethodImpl(Inline)]
        public byte[] GetBytes(string src)
            => Effector.GetBytes(src);

        [MethodImpl(Inline)]
        public int GetBytes(ReadOnlySpan<char> src, Span<byte> dst)
            => Effector.GetBytes(src, dst);

        [MethodImpl(Inline)]
        public byte[] GetBytes(char[] src)
            => Effector.GetBytes(src);

        [MethodImpl(Inline)]
        public int GetBytes(char* src, int charCount, byte* bytes, int byteCount)
            => Effector.GetBytes(src, charCount, bytes, byteCount);

        [MethodImpl(Inline)]
        public string GetString(byte[] src)
            => Effector.GetString(src);

        [MethodImpl(Inline)]
        public string GetString(ReadOnlySpan<byte> src)
            => Effector.GetString(src);

        [MethodImpl(Inline)]
        public string GetString(byte* src, int byteCount)
            => Effector.GetString(src, byteCount);

        [MethodImpl(Inline)]
        public string GetString(byte[] src, int index, int count)
            => Effector.GetString(src, index, count);
    }

}