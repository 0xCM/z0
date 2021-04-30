//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static Rules;

    [ApiHost]
    public readonly struct DataParser
    {
        [Op]
        public static Outcome parse(string src, out Timestamp dst)
            => Time.parse(src,out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out Name dst)
        {
            dst = src ?? EmptyString;
            return true;
        }

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out Identifier dst)
        {
            dst = src ?? EmptyString;
            return true;
        }

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out TextBlock dst)
        {
            dst = src ?? EmptyString;
            return true;
        }

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out MemoryAddress dst)
            => AddressParser.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out Address64 dst)
            => AddressParser.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out Address32 dst)
            => AddressParser.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out Address16 dst)
            => AddressParser.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out Address8 dst)
            => AddressParser.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome numeric<T>(string src, out T dst)
            => Numeric.parse(src, out dst);

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
        public static Outcome parse(string src, out bool dst)
            => bool.TryParse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out ByteSize dst)
            => ByteSize.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out string dst)
        {
            dst = src ?? EmptyString;
            return true;
        }

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out SymExpr dst)
        {
            dst = src ?? EmptyString;
            return true;
        }

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out ClrMemberName dst)
        {
            dst = Clr.membername(src);
            return true;
        }

        [MethodImpl(Inline), Op]
        public static bool parse(string src, Bounded<int> bounds, out int dst, out Outcome outcome)
            => Rules.parse(src,bounds, out dst, out outcome);

        [MethodImpl(Inline)]
        public static Outcome eparse<T>(string src, out T dst)
            where T : unmanaged
                => ClrEnums.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out BinaryCode dst)
            => CodeBlocks.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out OpUri dst)
            => ApiUri.parse(src, out dst);

        [Op]
        public static Outcome parse(string src, out CliToken dst)
            => CliTokens.parse(src, out dst);

        [Op]
        public static Outcome parse(string src, out MemoryRange dst)
            => MemoryRangeParser.parse(src, out dst);
    }
}