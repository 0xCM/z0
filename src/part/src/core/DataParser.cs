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
        //"yyyy-MM-dd.HH.mm.ss.fff";
        [Op]
        public static Outcome parse(string src, out Timestamp dst)
        {
            var outcome = Outcome.Empty;
            dst = Timestamp.Zero;
            var dash = text.index(src, Chars.Dash);
            if(dash == NotFound)
                return (false, "Date separator not found");

            var date = dash - 4;
            if(date < 0)
                return (false, $"The date index {date} is negative");

            var dot = text.index(src,Chars.Dot);
            if(dot == NotFound)
                return (false, "Time separator not found");

            var time = dot + 1;
            if(time <= date)
                return (false, $"The time separator index {time} is invalid");

            var seg0 = text.slice(src, date, 10).Split(Chars.Dash);
            if(seg0.Length != 3)
                return (false, $"The date segment has {seg0.Length} segments and should have 3");

            var seg1 = text.slice(src, time + 1).Split(Chars.Dot);

            if(seg1.Length != 4)
                return (false, $"The time segment has {seg1.Length} segments and should have 4");

            var fffBounds = bounded(0,999);
            if(!parse(skip(seg0,0), out int yyyy))
                return (false, "Attempt to parse year failed");
            if(!parse(skip(seg0,1), out int MM))
                return (false, "Attempt to parse month failed");
            if(!parse(skip(seg0,2), out int dd))
                return (false, "Attempt to parse day failed");
            if(!parse(skip(seg1,0), out int HH))
                return (false, "Attempt to parse hour failed");
            if(!parse(skip(seg1,1), out int mm))
                return (false, "Attempt to parse minutes failed");
            if(!parse(skip(seg1,2), out int ss))
                return (false, "Attempt to parse seconds failed");
            if(!parse(skip(seg1,3), fffBounds, out int fff, out outcome))
                return outcome;

            dst =  new DateTime(yyyy,MM,dd,HH, mm, ss, fff);

            return true;
        }

        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out Name dst)
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
        public static bool parse(string src, Bounded<int> bounds, out int dst, out Outcome outcome)
        {
            outcome = Numeric.parse(src, out dst);
            if(!outcome)
                return false;

            if(!satisfied(bounds,dst))
            {
                outcome = (false, $"The parsed value {dst} is not with the required range {bounds}");
                return false;
            }
            return true;
        }

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