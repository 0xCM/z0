//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
 
    using static zfunc;
    using static BitParts;
   
    partial class Bits
    {                
        [MethodImpl(Inline)]
        public static byte mix(N0 parity, byte x, byte y)
        {
            var mask = Even8.Select;
            var xE = Bits.project(select(x,mask), Even8.Select);
            var yE = Bits.project(select(y,mask), Odd8.Select);
            var xEy = xE | yE;
            return (byte)xEy;
        }

        [MethodImpl(Inline)]
        public static byte mix(N1 parity, byte x, byte y)
        {
            var mask = Odd8.Select;
            var xO = Bits.project(select(x, mask), Even8.Select);
            var yO = Bits.project(select(y, mask), Odd8.Select);
            var xOy = xO | yO;
            return (byte)xOy;
        }

        [MethodImpl(Inline)]
        public static ushort mix(N0 parity, ushort x, ushort y)
        {
            var mask = Even16.Select;
            var xE = Bits.project(select(x,mask), Even16.Select);
            var yE = Bits.project(select(y,mask), Odd16.Select);
            var xEy = xE | yE;
            return (ushort)xEy;
        }

        [MethodImpl(Inline)]
        public static ushort mix(N1 parity, ushort x, ushort y)
        {
            var mask = Odd16.Select;
            var xO = Bits.project(select(x, mask), Even16.Select);
            var yO = Bits.project(select(y, mask), Odd16.Select);
            var xOy = xO | yO;
            return (ushort)xOy;
        }

        [MethodImpl(Inline)]
        public static uint mix(N0 parity, uint x, uint y)
        {
            var mask = Even32.Select;
            var xE = Bits.project(select(x,mask), Even32.Select);
            var yE = Bits.project(select(y,mask), Odd32.Select);
            var xEy = xE | yE;
            return xEy;
        }

        [MethodImpl(Inline)]
        public static uint mix(N1 parity, uint x, uint y)
        {
            var mask = Odd32.Select;
            var xO = Bits.project(select(x, mask), Even32.Select);
            var yO = Bits.project(select(y, mask), Odd32.Select);
            var xOy = xO | yO;
            return xOy;
        }

        [MethodImpl(Inline)]
        public static ulong mix(N0 parity, ulong x, ulong y)
        {
            var mask = Even64.Select;
            var xE = Bits.project(select(x,mask), Even64.Select);
            var yE = Bits.project(select(y,mask), Odd64.Select);
            var xEy = xE | yE;
            return xEy;
        }

        [MethodImpl(Inline)]
        public static ulong mix(N1 parity, ulong x, ulong y)
        {
            var mask = Odd64.Select;
            var xO = Bits.project(select(x, mask), Even64.Select);
            var yO = Bits.project(select(y, mask), Odd64.Select);
            var xOy = xO | yO;
            return xOy;
        }
    }
}