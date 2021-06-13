//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

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
    }
}