//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly struct DataParser
    {
        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out Name dst)
        {
            dst = src;
            return true;
        }

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out MemoryAddress dst)
            => Addresses.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out ClrToken dst)
        {
            if(HexNumericParser.parse32u(src, out var result))
            {
                dst = result;
                return true;
            }
            else
            {
                dst = ClrToken.Empty;
                return false;
            }
        }

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out Address64 dst)
            => Addresses.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out Address32 dst)
            => Addresses.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out Address16 dst)
            => Addresses.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out Address8 dst)
            => Addresses.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out byte dst)
            => Numeric.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out short dst)
            => Numeric.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out ushort dst)
            => Numeric.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out int dst)
            => Numeric.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out uint dst)
            => Numeric.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out long dst)
            => Numeric.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out ulong dst)
            => Numeric.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out bit dst)
            => bit.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out ByteSize dst)
            => ByteSize.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out string dst)
        {
            dst = src;
            return true;
        }


        [MethodImpl(Inline)]
        public static Outcome eparse<T>(string src, out T dst)
            where T : unmanaged, Enum
                => Enums.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out BinaryCode dst)
        {
            var result = HexByteParser.ParseData(src, out var data);
            if(result)
            {
                dst = data.Storage;
                return result;
            }
            else
            {
                dst = BinaryCode.Empty;
                return result;
            }
        }

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out OpUri dst)
            => ApiUri.parse(src, out dst);
    }
}