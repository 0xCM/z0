//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata.Ecma335;

    using static Root;
    using static Rules;
    using static core;

    [ApiHost]
    public readonly struct DataParser
    {
        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out byte dst)
            => NumericParser.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out short dst)
            => NumericParser.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out ushort dst)
            => NumericParser.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out int dst)
            => NumericParser.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out uint dst)
            => NumericParser.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out long dst)
            => NumericParser.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out ulong dst)
            => NumericParser.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out Hex8 dst)
            => HexNumericParser.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out Hex16 dst)
            => HexNumericParser.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out Hex32 dst)
            => HexNumericParser.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out Hex64 dst)
            => HexNumericParser.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out bool dst)
            => BitParser.semantic(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out bit dst)
            => bit.parse(src, out dst);

        [MethodImpl(Inline)]
        public static Outcome numeric<T>(string src, out T dst)
            => NumericParser.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out Timestamp dst)
            => Time.parse(src,out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out DateTime dst)
            => DateTime.TryParse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out Name dst)
        {
            dst = src ?? EmptyString;
            return true;
        }

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out utf8 dst)
        {
            dst = src ?? utf8.Empty;
            return true;
        }

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out Identifier dst)
        {
            dst = src ?? EmptyString;
            return true;
        }

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out SymIdentity dst)
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

        [MethodImpl(Inline)]
        public static Outcome eparse<T>(string src, out T dst)
            where T : unmanaged
                => Enums.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out ByteSize dst)
            => Sizes.parse(src, out dst);

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out BitWidth dst)
            => Sizes.parse(src, out dst);

        [MethodImpl(Inline)]
        public static Outcome parse<T>(string src, out Size<T> dst)
            where T : unmanaged
                => Sizes.parse(src, out dst);

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
        public static Outcome parse(string src, out StringAddress dst)
        {
            dst = TextTools.address(src);
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

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out CliToken dst)
        {
            var i = TextTools.index(src,Chars.Colon);
            var outcome = Outcome.Empty;
            dst = CliToken.Empty;
            if(i != NotFound)
            {
                outcome = HexNumericParser.parse8u(src.LeftOfIndex(i), out var table);
                if(!outcome)
                    return outcome;

                outcome = HexNumericParser.parse32u(TextTools.right(src,i), out var row);
                if(!outcome)
                    return outcome;

                dst = Clr.token((TableIndex)table, row);
                return true;
            }
            else
            {
                outcome = HexNumericParser.parse32u(src, out var token);
                if(!outcome)
                    return outcome;
                dst = token;
                return true;
            }
        }

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out MemoryRange dst)
            => MemoryRangeParser.parse(src, out dst);

        [MethodImpl(Inline)]
        public static Outcome parse<T>(string src, out Setting<T> dst, char delimiter = Chars.Colon)
        {
            dst = Settings.empty<T>();
            if(nonempty(src))
            {
                var name = EmptyString;
                var input = src;
                if(SymbolicQuery.contains(src, delimiter))
                {
                    name = src.LeftOfFirst(delimiter);
                    input = src.RightOfFirst(delimiter);
                }

                if(typeof(T) == typeof(string))
                {
                    dst = Settings.define(name, generic<T>(input));
                    return true;
                }
                else if (typeof(T) == typeof(bool))
                {
                    if(DataParser.parse(input, out bool value))
                    {
                        dst = Settings.define(name, generic<T>(value));
                        return true;
                    }
                }
                else if(typeof(T) == typeof(bit))
                {
                    if(DataParser.parse(input, out bit u1))
                    {
                        dst = Settings.define(name, generic<T>(u1));
                        return true;
                    }
                }
                else if(DataParser.numeric(input, out T g))
                {
                    dst = Settings.define(name, g);
                    return true;
                }
                else if(typeof(T).IsEnum)
                {
                    if(Enums.parse(typeof(T), src, out object o))
                    {
                        dst = Settings.define(name, (T)o);
                        return true;
                    }
                }
                else if(src.Length == 1 && typeof(T) == typeof(char))
                {
                    dst = Settings.define(name, generic<T>(name[0]));
                    return true;
                }
            }
            return false;
        }
     }
}