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
        public static Outcome parse(TextLine src, out SymLiteral dst)
        {
            var outcome = Outcome.Success;
            var j=0;
            var cells = src.Split(Chars.Pipe);
            if(cells.Length != SymLiteral.FieldCount)
            {
                dst = default;
                return (false, AppMsg.FieldCountMismatch.Format(SymLiteral.FieldCount, cells.Length));
            }

            outcome += parse(skip(cells,j), out dst.Component);
            outcome += parse(skip(cells,j), out dst.Type);
            outcome += parse(skip(cells,j), out dst.Position);
            outcome += parse(skip(cells,j), out dst.Name);
            outcome += parse(skip(cells,j), out dst.Symbol);
            outcome += eparse(skip(cells,j), out dst.DataType);
            outcome += parse(skip(cells,j), out dst.ScalarValue);
            outcome += parse(skip(cells,j), out dst.Hidden);
            outcome += parse(skip(cells,j), out dst.Description);
            outcome += parse(skip(cells,j), out dst.Identity);
            return outcome;
        }

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
        {
            dst = default;
            var result = BitParser.semantic(src, out var b);
            if(result)
            {
                dst = b;
            }
            return result;
        }

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
        public static Outcome parse(string src, out FS.FileName dst)
        {
            dst = FS.file(src);
            return true;
        }

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out FS.FolderPath dst)
        {
            dst = FS.dir(src);
            return true;
        }

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out FS.FilePath dst)
        {
            dst = FS.path(src);
            return true;
        }

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out FS.FileExt dst)
        {
            dst = FS.ext(src);
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
            var i = text.index(src,Chars.Colon);
            var outcome = Outcome.Empty;
            dst = CliToken.Empty;
            if(i != NotFound)
            {
                outcome = HexNumericParser.parse8u(src.LeftOfIndex(i), out var table);
                if(!outcome)
                    return outcome;

                outcome = HexNumericParser.parse32u(text.right(src,i), out var row);
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

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out ToolId dst)
        {
            dst = src;
            return true;
        }

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