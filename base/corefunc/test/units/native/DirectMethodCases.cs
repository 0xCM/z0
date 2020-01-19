//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;

    using static zfunc;


    class DirectMethodCases
    {
        [Op]
        public static uint and_ng(uint a, uint b)
            => a & b;
        [Op]
        public static uint or_ng(uint a, uint b)
            => a | b;

        [Op]
        public static uint xor_ng(uint a, uint b)
            => a ^ b;
    }

}