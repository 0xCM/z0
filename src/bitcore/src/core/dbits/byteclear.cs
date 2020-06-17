//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;
    
     partial class Bits
     {                
          /// <summary>
          /// Disables a sequence of 8 source bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          [MethodImpl(Inline), Op]
          public static ushort byteclear(ushort src, byte index)
          {
               var mask = uint.MaxValue ^ ((uint)byte.MaxValue << index);
               return (ushort)(mask & src);
          }
     
          /// <summary>
          /// Disables a sequence of 8 source bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          [MethodImpl(Inline), Op]
          public static uint byteclear(uint src, byte index)
          {
               var mask = uint.MaxValue ^ ((uint)byte.MaxValue << index);
               return mask & src;
          }

          /// <summary>
          /// Disables a sequence of 8 source bits starting at a specified index
          /// </summary>
          /// <param name="src">The bit source</param>
          /// <param name="index">The index at which to begin clearing bits</param>
          [MethodImpl(Inline), Op]
          public static ulong byteclear(ulong src, byte index)
          {
               var mask = ulong.MaxValue ^ ((ulong)byte.MaxValue << index);
               return mask & src;
          }
     }
}