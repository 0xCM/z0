//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Eliminates trailing zeros in the source span
        /// </summary>
        /// <param name="src">The source span</param>
        public static Span<byte> TrimEnd(this Span<byte> src)
        {
            var length = src.Length;
            for(var i= length - 1; i>=0; i--)
            {
                ref readonly var x = ref AsInternal.skip(src,i);
                if(x != 0)
                    return Z0.As.slice(src, 0,length);
            }
            return Span<byte>.Empty;
        }
    }
}