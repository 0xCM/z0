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

    public static class BitPackX
    {
         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this byte src)
            => BitPack.bitspan(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this sbyte src)
            => BitPack.bitspan((byte)src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this ushort src)
            => BitPack.bitspan(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this short src)
            => BitPack.bitspan((ushort)src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this int src)
            => BitPack.bitspan((uint)src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this uint src)
            => BitPack.bitspan(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this long src)
            => BitPack.bitspan((ulong)src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this ulong src)
            => BitPack.bitspan(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this float src)
            => BitPack.bitspan(BitConvert.ToUInt32(src));

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this double src)
            => BitPack.bitspan(BitConvert.ToUInt64(src));

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this Span<byte> src)
            => BitPack.bitspan(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this ReadOnlySpan<byte> src)
            => BitPack.bitspan(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this Span<ushort> src)
            => BitPack.bitspan(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this ReadOnlySpan<ushort> src)
            => BitPack.bitspan(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this Span<uint> src)
            => BitPack.bitspan(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this ReadOnlySpan<uint> src)
            => BitPack.bitspan(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this Span<ulong> src)
            => BitPack.bitspan(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this ReadOnlySpan<ulong> src)
            => BitPack.bitspan(src);
         
         // public static T TakeScalar<T>(this BitSpan src)
         // {
             
         // }

    }
}