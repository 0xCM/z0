//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Globalization;

    using static Root;
    using static System.StringSplitOptions;
    using static HexFormatSpecs;
    using static core;

    [ApiHost]
    public readonly struct HexByteParser
    {
        public static HexByteParser Service
            => default(HexByteParser);

        [MethodImpl(Inline)]
        public static bool HasPreSpec(string src)
            => src.TrimStart().StartsWith(PreSpec);

        [MethodImpl(Inline)]
        public static bool HasPostSpec(string src)
            => src.TrimEnd().EndsWith(PostSpec);

        /// <summary>
        /// Parses a sequence of hex bytes, delimited by a space or comma
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        public static Outcome hexbytes(string src, out BinaryCode dst)
        {
            dst = BinaryCode.Empty;
            var result = Outcome.Success;
            if(empty(src))
                return result;

            var sep = delimiter(src);
            var parts = src.Replace(CharText.EOL, CharText.Space).SplitClean(sep).ToReadOnlySpan();
            var count = parts.Length;
            var buffer = alloc<byte>(count);
            ref var target = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var part = ref skip(parts,i);
                result = Hex.parse8u(part, out seek(target,i));
                if(result.Fail)
                {
                    result = (false, string.Format("The source value '{0}' could not be parsed", part));
                    return result;
                }

            }
            dst = buffer;
            return result;
        }

        public static Outcome<uint> hexbytes(string src, Span<byte> dst)
        {
            var size = 0u;
            var limit = (uint)dst.Length;
            var result = Outcome.Success;
            if(empty(src))
                return size;
            var sep = delimiter(src);
            var parts = src.Replace(CharText.EOL, CharText.Space).SplitClean(sep).ToReadOnlySpan();
            var count = src.Length;
            for(var i=0u; i<count && i<limit; i++)
            {
                ref readonly var part = ref skip(parts,i);
                result = Hex.parse8u(part, out seek(dst,i));
                if(result.Fail)
                    return (false,size);
                else
                    size++;
            }
            return size;
        }


        [Op]
        public static bool parse(string src, out byte[] dst)
        {
            try
            {
                var s0 = src.Trim();
                var len = s0.Length;
                if(HasPreSpec(s0))
                    s0 = text.substring(s0, len - PreSpec.Length);
                else if(HasPostSpec(s0))
                    s0 = text.substring(s0, 0, len - PostSpec.Length);
                var blocks = split(s0, Chars.Space).View;
                var count = blocks.Length;
                var buffer = alloc<byte>(count);
                ref var target = ref first(buffer);
                for(var i=0; i<count; i++)
                    seek(target, count-1-i) = byte.Parse(skip(blocks, i), NumberStyles.HexNumber);
                dst = buffer;

                return true;
            }
            catch(Exception)
            {
                dst = Array.Empty<byte>();
                return false;
            }
        }

        public byte Succeed(string src)
        {
            if(byte.TryParse(ClearSpecs(src), NumberStyles.HexNumber, null, out var b))
                return b;
            else
                return 0;
        }

        /// <summary>
        /// Parses a space-delimited sequence of hex text
        /// </summary>
        /// <param name="src">The space-delimited hex</param>
        public static Outcome ParseData(string src, out byte[] dst)
        {
            try
            {
                dst = src.Trim().Split(Chars.Space).Select(x => byte.Parse(x, NumberStyles.HexNumber));
                return true;
            }
            catch(Exception e)
            {
                dst = Array.Empty<byte>();
                return (e,$"Input:{src}");
            }
        }

        [MethodImpl(Inline)]
        static char delimiter(string src)
            => text.index(src,Chars.Comma) > 0 ? Chars.Comma : Chars.Space;

        [Op]
        static Index<string> split(string src, char sep, bool clean = true)
            => src.Split(sep,  clean ? RemoveEmptyEntries : None);
    }
}