//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    
    using static Seed;

    public abstract class UnitTest<U> : TestContext<U>, IUnitTest, ITestControl
        where U : UnitTest<U>
    {        
        protected virtual bool TraceDetailEnabled
            => false;

        public static N0 n0 => default;

        public static N1 n1 => default;

        public static N2 n2 => default;

        public static N3 n3 => default;
        
        public static N4 n4 => default;

        public static N5 n5 => default;

        public static N7 n7 => default;

        public static N8 n8 => default;
        
        public static N9 n9 => default;
        
        public static N10 n10 => default;
        
        public static N11 n11 => default;

        public static N12 n12 => default;

        public static N13 n13 => default;

        public static N15 n15 => default;

        public static N16 n16 => default;

        public static N21 n21 => default;

        public static N32 n32 => default;

        public static N34 n34 => default;

        public static N50 n51 => default;

        public static N64 n64 => default;

        public static N128 n128 => default;

        public static N256 n256 => default;

        //public static N512 n512 => default;

        public static N1024 n1024 => default;

        public const sbyte z8i = 0;

        public const byte z8 = 0;

        public const short z16i = 0;

        public const ushort z16 = 0;

        public const int z32i = 0;

        public const uint z32 = 0;

        public const long z64i = 0;

        public const ulong z64 = 0;

        public const float z32f = 0;

        public const double z64f = 0;
 
    }
}