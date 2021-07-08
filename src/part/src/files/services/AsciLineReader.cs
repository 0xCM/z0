//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Root;
    using static core;

    using SQ = SymbolicQuery;

    public struct AsciLineReader : IDisposable
    {
        public static AsciLineReader open(StreamReader src)
            => new AsciLineReader(src);

        public static AsciLineReader open(FS.FilePath src)
            => new AsciLineReader(src.AsciReader());

        readonly StreamReader Source;

        uint LineCount;

        uint Offset;

        Index<byte> _Buffer;

        public AsciLineReader(StreamReader src)
        {
            Source = src;
            LineCount = 0;
            Offset = 0;
            _Buffer = alloc<byte>(1024);
        }

        [MethodImpl(Inline)]
        Span<byte> Buffer()
            => _Buffer.Clear();


        public void Dispose()
        {
            Source?.Dispose();
        }

        [MethodImpl(Inline)]
        static uint convert(ReadOnlySpan<char> src, Span<byte> dst)
        {
            var count = (uint)min(src.Length, dst.Length);
            for(var i=0; i<count; i++)
                seek(dst,i) = (byte)skip(src,i);
            return count;
        }

        public bool Next(out AsciLine dst)
        {
            dst = AsciLine.Empty;
            var _line = Source.ReadLine();
            if(_line == null)
                return false;
            var buffer = Buffer();
            var count = convert(_line, buffer);
            var data = slice(buffer,0,count);

            LineCount++;

            if(ParseLineNumber(data, out var length, out var number))
                dst = new AsciLine(number, Offset, slice(data, (int)length));
            else
                dst = new AsciLine(LineCount, Offset, data);

            Offset+=length;

            return true;
        }

        static bool IsNumbered(ReadOnlySpan<byte> src)
        {
            if(src.Length < 9)
                return false;

            if(skip(src,8) != Chars.Colon)
                return false;

            for(var i=0; i<7; i++)
            {
                if(!SQ.digit(base10, skip(src,i)))
                    return false;
            }
            return true;
        }

        [Op]
        static Outcome ParseLineNumber(ReadOnlySpan<byte> src, out uint j, out uint dst)
        {
            j=0;
            dst = 0;
            const char Delimiter = Chars.Colon;
            const byte LastIndex = 8;
            const byte ContentLength = 9;
            if(!IsNumbered(src))
                return false;

            var result = Outcome.Failure;
            var storage = CharBlock8.Null;
            var buffer = storage.Data;

            while(j++ <= LastIndex)
            {
                ref readonly var c = ref skip(src, j);
                if(SQ.digit(base10, c))
                    seek(buffer, j) = (char)c;
                else if(c == Delimiter && j==LastIndex)
                {
                    result = uint.TryParse(buffer, out dst);
                    break;
                }
                else
                    break;
            }
            return result;
        }
    }
}