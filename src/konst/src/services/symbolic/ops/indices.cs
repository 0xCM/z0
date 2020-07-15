//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Symbolic
    {        
        /// <summary>
        /// Finds indices of the source cells that contain a specified character and returns the number of matches found
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="match">The character to match</param>
        /// <param name="dst">The index target</param>
        [MethodImpl(Inline), Op]
        public static int indices(ReadOnlySpan<char> src, char match, Span<int> dst)
        {
            var j = 0u;
            for(var i=0u; i<src.Length; i++)
                if(z.skip(src,i) == match)
                    z.seek(dst, j++) = (int)i;
            return (int)j;
        }

        [MethodImpl(Inline), Op]
        public static Span<int> indices(ReadOnlySpan<char> src, char match)
        {
            Span<int> dst = new int[src.Length];
            var j = indices(src,match,dst);
            return dst.Slice(0,j);
        }

        /// <summary>
        /// Finds indices of the source cells that contain a specified value 
        /// and returns the number of matches found
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="match">The value to match</param>
        /// <param name="dst">The index target</param>
        [MethodImpl(Inline), Op]
        public static int indices(ReadOnlySpan<byte> src, byte match, Span<int> dst)
        {
            var j = 0u;
            for(var i=0u; i<src.Length; i++)
                if(skip(src,i) == match)
                    seek(dst, j++) =(int)i;
            return (int)j;
        }

        [MethodImpl(Inline), Op]
        public static Span<int> indices(ReadOnlySpan<byte> src, byte match)
        {
            Span<int> dst = new int[src.Length];
            var j = indices(src,match,dst);
            return dst.Slice(0,j);
        }        
    }
}