//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;

    public interface ISpanProjector
    {

    }

    [Free]
    public interface ICellProjector<S,T>
        where S : struct
        where T : struct
    {
        void Project(in S src, ref T dst);
    }

    public interface ISpanProjector<S,T> : ISpanProjector
    {
        void Project(ReadOnlySpan<S> src, Span<T> dst);
    }

    public interface IDataDecoder<T,S> : ISpanProjector<T,S>
    {
        void Decode(ReadOnlySpan<T> src, Span<S> dst);

        void ISpanProjector<T,S>.Project(ReadOnlySpan<T> src, Span<S> dst)
            => Decode(src,dst);
    }

    public interface IDataEncoder<S,T> : ISpanProjector<S,T>
        where S : struct
        where T : struct
    {
        ByteSize Encode(ReadOnlySpan<S> src, Span<T> dst);

        void ISpanProjector<S,T>.Project(ReadOnlySpan<S> src, Span<T> dst)
            => Encode(src,dst);
    }

    public interface ITextEncoder<H> : IDataEncoder<char,byte>, IDataDecoder<byte,char>
    {
        string EncodingName {get;}

        int CodePage {get;}

        ReadOnlySpan<byte> Preamble {get;}

        int WindowsCodePage {get;}

        string WebName {get;}

        char[] GetChars(byte[] bytes);

        int GetCharCount(ReadOnlySpan<byte> bytes);

        unsafe int GetCharCount(byte* bytes, int count);

        unsafe int GetChars(byte* bytes, int byteCount, char* chars, int charCount);

        byte[] GetBytes(string s);

        void GetChars(ReadOnlySpan<byte> src, Span<char> dst);

        ByteSize IDataEncoder<char,byte>.Encode(ReadOnlySpan<char> src, Span<byte> dst)
            => GetBytes(src,dst);

        void IDataDecoder<byte,char>.Decode(ReadOnlySpan<byte> src, Span<char> dst)
            => GetChars(src,dst);

        /// <summary>
        /// Encodes the source into the target, returning the number of bytes injected
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The data target</param>
        int GetBytes(ReadOnlySpan<char> src, Span<byte> dst);

        byte[] GetBytes(char[] chars);

        int GetByteCount(ReadOnlySpan<char> chars);

        int GetByteCount(string s);

        int GetByteCount(string s, int index, int count);

        unsafe int GetByteCount(char* chars, int count);

        unsafe int GetBytes(char* chars, int charCount, byte* bytes, int byteCount);

        string GetString(byte[] bytes);

        string GetString(ReadOnlySpan<byte> bytes);

        unsafe string GetString(byte* bytes, int byteCount);

        string GetString(byte[] bytes, int index, int count);
    }
}