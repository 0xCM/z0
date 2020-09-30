//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct BranchTables
    {
        [Op]
        public uint map1(ushort src)
        {
            switch(src)
            {
                case 12:
                    return 33u*src;
                case 90:
                    return 66u*src;
                case 190:
                    return 12u*src;
                case 7:
                    return 2u*src;
                case 25000:
                    return 422u*src;
                case 35000:
                    return 522u*src;
                default:
                    return uint.MaxValue;
            }

        }

        [Op]
        public uint map2(byte src)
        {
            switch(src)
            {
                default:
                return 13;

            }
        }
    }
}