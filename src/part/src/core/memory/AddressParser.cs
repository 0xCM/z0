//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static memory;

    [ApiHost]
    public readonly struct AddressParser
    {
        const NumericKind Closure = UnsignedInts;

        [Op]
        public static Outcome parse(string src, out MemoryAddress dst)
        {
            var attempt = HexNumericParser.parse64u(src);
            if(attempt)
            {
                dst = attempt.Value;
                return true;
            }
            else
            {
                dst = MemoryAddress.Zero;
                return false;
            }
        }

        [Op]
        public static Outcome parse(string src, out Address64 dst)
        {
            var attempt = HexNumericParser.parse64u(src);
            if(attempt)
            {
                dst = attempt.Value;
                return true;
            }
            else
            {
                dst = Address64.Zero;
                return false;
            }
        }

        [Op]
        public static Outcome parse(string src, out Address32 dst)
        {
            var attempt = HexNumericParser.parse32u(src);
            if(attempt)
            {
                dst = attempt.Value;
                return true;
            }
            else
            {
                dst = Address32.Zero;
                return false;
            }
        }

        [Op]
        public static Outcome parse(string src, out Address16 dst)
        {
            var attempt = HexNumericParser.parse16u(src);
            if(attempt)
            {
                dst = attempt.Value;
                return true;
            }
            else
            {
                dst = Address16.Zero;
                return false;
            }
        }

        [Op]
        public static Outcome parse(string src, out Address8 dst)
        {
            var attempt = HexNumericParser.parse8u(src);
            if(attempt)
            {
                dst = attempt.Value;
                return true;
            }
            else
            {
                dst = Address8.Zero;
                return false;
            }
        }

        [Op]
        public static string format(RelativeAddress src)
            => src.Offset.FormatAsmHex(4);

        [Op, Closures(Closure)]
        public static string format<T>(RelativeAddress<T> src)
            where T : unmanaged
        {
            if(width<T>() == 8)
                return string.Format("{0} + {1}", src.Base, @as<T,byte>(src.Offset).FormatAsmHex());
            else if(width<T>() == 16)
                return string.Format("{0} + {1}", src.Base, @as<T,ushort>(src.Offset).FormatAsmHex());
            else if(width<T>() == 32)
                return string.Format("{0} + {1}", src.Base, @as<T,uint>(src.Offset).FormatAsmHex());
            else
                return string.Format("{0} + {1}", src.Base, @as<T,ulong>(src.Offset).FormatAsmHex());
        }
    }
}