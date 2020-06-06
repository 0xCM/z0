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
    using static Typed;

    partial class Symbolic
    {
        [MethodImpl(Inline), Op]
        public static int length(in AsciCode16 src)
        {
            var i = first(src, 0);
            return i != -1 ? i+1 : 16;

        }

        [MethodImpl(Inline), Op]
        public static int first(in AsciCode16 src, byte match)
        {                        
            var dst = ByteBlocks.u8s(ByteBlocks.alloc(n16));
            SymBits.vstore(src.Data, ref head(dst));
            return first(dst, match);
        }

        [MethodImpl(Inline), Op]
        public static int first(ReadOnlySpan<byte> src, byte match)
        {
            for(var i=0; i<src.Length; i++)
                if(skip(src,i) == match)
                    return i;
            return -1;
        }

        /// <summary>
        /// Returns the index of the first source character that matches a target character
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="match">The character to match</param>
        [MethodImpl(Inline), Op]
        public static int first(ReadOnlySpan<char> src, char match)
        {
            for(var i=0; i<src.Length; i++)
                if(skip(src,i) == match)
                    return i;
            return -1;
        }
    }
}