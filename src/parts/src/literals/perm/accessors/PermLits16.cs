//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Perm16L;

    partial class PermLits
    {
        public const Perm16L Perm16Identity =  
            (Perm16L)(
              (ulong)X0 << 00 | (ulong)X1 << 04 | (ulong)X2 << 08 | (ulong)X3 << 12 
            | (ulong)X4 << 16 | (ulong)X5 << 20 | (ulong)X6 << 24 | (ulong)X7 << 28 
            | (ulong)X8 << 32 | (ulong)X9 << 36 | (ulong)XA << 40 | (ulong)XB << 44 
            | (ulong)XC << 48 | (ulong)XD << 52 | (ulong)XE << 56 | (ulong)XF << 60);    
    }
}