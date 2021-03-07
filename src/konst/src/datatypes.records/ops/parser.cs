//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Records
    {
        [MethodImpl(Inline)]
        public static RowParser<T> parser<T>(ParseFunction<T> f, char delimiter = FieldDelimiter)
            where T : struct, IRecord<T>
                => new RowParser<T>(f,delimiter);

        [Op]
        public static bool parse(string src, out MemoryAddress dst)
            => Addresses.parse(src, out dst);

        [Op]
        public static bool parse(string src, out Address32 dst)
            => Addresses.parse(src, out dst);

        [Op]
        public static bool parse(string src, out Address16 dst)
            => Addresses.parse(src, out dst);

        [Op]
        public static bool parse(string src, out Address8 dst)
            => Addresses.parse(src, out dst);

        [Op]
        public static bool parse(string src, out byte dst)
            => Numeric.parse(src, out dst);

        [Op]
        public static bool parse(string src, out short dst)
            => Numeric.parse(src, out dst);

        [Op]
        public static bool parse(string src, out ushort dst)
            => Numeric.parse(src, out dst);

        [Op]
        public static bool parse(string src, out int dst)
            => Numeric.parse(src, out dst);

        [Op]
        public static bool parse(string src, out uint dst)
            => Numeric.parse(src, out dst);

        [Op]
        public static bool parse(string src, out long dst)
            => Numeric.parse(src, out dst);

        [Op]
        public static bool parse(string src, out ulong dst)
            => Numeric.parse(src, out dst);

        [Op]
        public static bool parse(string src, out bit dst)
            => bit.parse(src, out dst);

        [Op]
        public static bool parse(string src, out ByteSize dst)
            => ByteSize.parse(src, out dst);

        [Op]
        public static bool eparse<T>(string src, out T dst)
            where T : unmanaged, Enum
        {
            var result = Enums.parse<T>(src);
            if(result)
            {
                dst = result.Value;
                return true;
            }
            else
            {
                dst = default;
                return false;
            }
        }

        [Op]
        public static bool parse(string src, out BinaryCode dst)
        {
            var result = HexByteParser.Service.ParseData(src);
            if(result)
            {
                dst = result.Value;
                return true;
            }
            else
            {
                dst = BinaryCode.Empty;
                return false;
            }
        }

        [Op]
        public static bool parse(string src, out OpUri dst)
        {
            var result = ApiUri.parse(src);
            if(result)
            {
                dst = result.Value;
                return true;
            }
            else
            {
                dst = OpUri.Empty;
                return false;
            }
        }
    }
}