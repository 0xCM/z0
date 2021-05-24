//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Root;
    using static core;
    using static Typed;

    [ApiHost]
    public readonly struct BitFormatter
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Formats a span as a bitgrid
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="rowlen">The number of bits in each row</param>
        /// <param name="maxbits">The maximum number of bits to format</param>
        /// <param name="showrow">Indicates whether the content of each row shold be preceded by the row index</param>
        public static string grid(Span<byte> src, int rowlen, int? maxbits = null, bool showrow = false)
        {
            var dst = bit.bitchars(src);
            var sb = text.build();
            var limit = maxbits ?? dst.Length;
            for(int i=0, rowidx=0; i<limit; i+= rowlen, rowidx++)
            {
                var remaining = dst.Length - i;
                var segment = Math.Min(remaining, rowlen);
                var rowbits = dst.Slice(i, segment);
                var rowprefix = showrow ? $"{rowidx.ToString().PadRight(3)} | " : string.Empty;
                var rowformat = rowprefix + new string(rowbits.Intersperse(Chars.Space));
                sb.AppendLine(rowformat);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Formats the content of a generic span of primal cells as a bitmatrix
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="rowlen">The number of bits in each row</param>
        /// <param name="maxbits">The maximum number of bits to format</param>
        /// <param name="showrow">Indicates whether the content of each row shold be preceded by the row index</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        public static string grid<T>(Span<T> src, int rowlen, int? maxbits = null, bool showrow = false)
            where T : unmanaged
                => grid(src.Bytes(),rowlen, maxbits, showrow);

        public static BitFormat DefaultConfig
            => BitFormat.configure(false);

        [Op]
        public static string format(params bit[] src)
            => format(src.ToReadOnlySpan());

        public static string format(ReadOnlySpan<bit> src)
        {
            var count = src.Length;
            if(count == 0)
                return EmptyString;

            var terms = src;
            Span<char> dst = stackalloc char[count];
            render(src, dst);
            return new string(dst);
        }

        [Op]
        public static void render(ReadOnlySpan<bit> src, Span<char> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                seek(dst,i) = skip(src,i).ToChar();
        }

        [Op]
        public static string format(object src, TypeCode type)
        {
            if(type == TypeCode.Byte || type == TypeCode.SByte)
                return format8(src);
            else if(type == TypeCode.UInt16 || type == TypeCode.Int16)
                return format16(src);
            else if(type == TypeCode.UInt32  || type == TypeCode.Int32 || type == TypeCode.Single)
                return format32(src);
            else if(type == TypeCode.UInt64 || type == TypeCode.Int64 || type == TypeCode.Double)
                return format64(src);
            else
                return EmptyString;
        }

        [Op]
        static string format8(object src)
            => bit.formatter<byte>().Format((byte)NumericBox.rebox(src, NumericKind.U8));

        [Op]
        static string format16(object src)
            => bit.formatter<ushort>().Format((ushort)NumericBox.rebox(src, NumericKind.U16));

        [Op]
        static string format32(object src)
            => bit.formatter<uint>().Format((uint)NumericBox.rebox(src, NumericKind.U32));

        [Op]
        static string format64(object src)
            => bit.formatter<ulong>().Format((ulong)NumericBox.rebox(src, NumericKind.U64));
    }
}