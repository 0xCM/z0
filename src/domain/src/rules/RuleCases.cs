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

    public readonly struct RuleCases
    {
        public const string SIB_0_Id = "SIBINDEX_ENCODE_SIB1()::[0]";

        public const string SIB_0_Data = "REXX=0      SIBSCALE[0b00] SIBINDEX[0b000] SIBBASE[bbb] SIB_BASE0()              | :=           |   INDEX=ArAX() SCALE=1";

        public const string SIB_0_OperandData = "REXX=0      SIBSCALE[0b00] SIBINDEX[0b000] SIBBASE[bbb] SIB_BASE0()";

        public const string SIB_0_OperatorData = ":=";

        public const string SIB_0_EffectData = "INDEX=ArAX() SCALE=1";
    }
}