//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Root;

    [ApiHost]
    public readonly struct AddressParser
    {
        const NumericKind Closure = UnsignedInts;

        [Op]
        public static Outcome parse(string src, out MemoryAddress dst)
        {
            var result = Hex.parse64u(src, out var a);
            if(result)
            {
                dst = a;
                return true;
            }
            else
            {
                dst = MemoryAddress.Zero;
                return result;
            }
        }

        [Op]
        public static Outcome parse(string src, out Address64 dst)
        {
            var result = Hex.parse64u(src, out var a);
            if(result)
            {
                dst = a;
                return true;
            }
            else
            {
                dst = Address64.Zero;
                return result;
            }
        }

        [Op]
        public static Outcome parse(string src, out Address32 dst)
        {
            var result = Hex.parse32u(src, out var a);
            if(result)
            {
                dst = a;
                return true;
            }
            else
            {
                dst = Address32.Zero;
                return result;
            }
        }

        [Op]
        public static Outcome parse(string src, out Address16 dst)
        {
            var result = Hex.parse16u(src, out var a);
            if(result)
            {
                dst = a;
                return true;
            }
            else
            {
                dst = Address16.Zero;
                return result;
            }
        }

        [Op]
        public static Outcome parse(string src, out Address8 dst)
        {
            var result = Hex.parse8u(src, out var a);
            if(result)
            {
                dst = a;
                return true;
            }
            else
            {
                dst = Address8.Zero;
                return result;
            }
        }
    }
}