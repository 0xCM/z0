//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct BitFormatter
    {
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
            => BitRender.formatter<byte>().Format((byte)NumericBox.rebox(src, NumericKind.U8));

        [Op]
        static string format16(object src)
            => BitRender.formatter<ushort>().Format((ushort)NumericBox.rebox(src, NumericKind.U16));

        [Op]
        static string format32(object src)
            => BitRender.formatter<uint>().Format((uint)NumericBox.rebox(src, NumericKind.U32));

        [Op]
        static string format64(object src)
            => BitRender.formatter<ulong>().Format((ulong)NumericBox.rebox(src, NumericKind.U64));
    }
}