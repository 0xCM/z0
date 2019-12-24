//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
 
    using static zfunc;

    partial class BitMasks
    {            

        public const byte Ones8u = byte.MaxValue;

        public const sbyte Ones8i = -1;

        public const ushort Ones16u = ushort.MaxValue;

        public const short Ones16i = -1;

        public const uint Ones32u = uint.MaxValue;

        public const int Ones32i = -1;

        public const ulong Ones64u = ulong.MaxValue;

        public const long Ones64i = -1;

    }

}