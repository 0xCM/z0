//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;    

   public enum Arrange2L : byte
   {
        A = 0b0,

        B = 0b01,

        C = 0b10,

        D = 0b11,

        AB = 0b1110_0100,    

        BA = 0b0100_1110,
   }
}