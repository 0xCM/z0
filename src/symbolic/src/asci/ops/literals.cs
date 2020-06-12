//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;
    using static Control;

    partial class AsciCodes
    {
        [MethodImpl(Inline), Op]
        static void literals(in char src, int count, ref AsciCharCode dst)
        {
            for(var i=0; i<count; i++)
                seek(ref dst,i) = (AsciCharCode)skip(src,i);
        }

        [MethodImpl(Inline), Op]
        static void literals(ReadOnlySpan<char> src, Span<AsciCharCode> dst)
        {
            var count = Math.Min(src.Length, dst.Length);
            literals(in head(src), count, ref head(dst));
        }   
    }
}