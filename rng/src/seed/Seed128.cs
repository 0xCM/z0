//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static class Seed128
    {
        public static RowVector<N2,ulong> Seed00 
            => new ulong[]{Seed64.Seed00, Seed64.Seed01};

        public static RowVector<N2,ulong> Seed01 
            => new ulong[]{Seed64.Seed02, Seed64.Seed03};

        public static RowVector<N2,ulong> Seed02 
            => new ulong[]{Seed64.Seed04, Seed64.Seed05};

        public static RowVector<N2,ulong> Seed03 
            => new ulong[]{Seed64.Seed06, Seed64.Seed07};

        public static RowVector<N2,ulong> Seed04 
            => new ulong[]{Seed64.Seed08, Seed64.Seed09};

        public static RowVector<N2,ulong> Seed05 
            => new ulong[]{Seed64.Seed10, Seed64.Seed11};
    }
}