//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace  Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;    
    
    using static zfunc;
    
    partial class xfunc
    {
        public static IEnumerable<ulong> ToU64Stream(this IEnumerable<Guid> guids)
        {
            foreach(var guid in guids)
            {
                var bytes = guid.ToByteArray();      
                yield return BitConverter.ToUInt64(bytes,0);
                yield return BitConverter.ToUInt64(bytes,4);
            }            
        }

        public static ulong[] ToU64Array(this IEnumerable<Guid> guids)
            => guids.ToU64Stream().ToArray();

        [MethodImpl(Inline)]
        public static T ValueOrDefault<T>(this T? x, T @default = default)
            where T : unmanaged
                => x != null ? x.Value : @default;

        /// <summary>
        /// Produces an array of bits from a stream of binary digits
        /// </summary>
        /// <param name="src">The source digits</param>
        public static Span<bit> ToBits(this IEnumerable<BinaryDigit> src)
            => src.Select(d => d == BinaryDigit.Zed ? bit.Off : bit.On).ToSpan();
   }
}