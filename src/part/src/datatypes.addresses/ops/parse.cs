//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Addresses
    {
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
    }
}