//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static root;
   
    partial class Bits
    {                        
        [MethodImpl(Inline), Op]
        public static byte stitch(byte left, int ldx, byte right, int rdx)
        {
            var a = (uint)left << ldx;
            var b = (uint)right >> rdx;
            return (byte)((a | b) >> rdx);
        }

        [MethodImpl(Inline), Op]
        public static ushort stitch(ushort left, int ldx, ushort right, int rdx)
        {
            var a = (uint)left << ldx;
            var b = (uint)right >> rdx;
            return (ushort)((a | b) >> rdx);
        }

        [MethodImpl(Inline), Op]
        public static uint stitch(uint left, int ldx, uint right, int rdx)
        {
            var a = left << ldx;
            var b = right >> rdx;
            return (a | b) >> rdx;
        }

        [MethodImpl(Inline), Op]
        public static ulong stitch(ulong left, int ldx, ulong right, int rdx)
        {
            var a = left << ldx;
            var b = right >> rdx;
            return (a | b) >> rdx;
        }
    }
}