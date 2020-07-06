//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static Root;

    partial struct asci
    {        

        [MethodImpl(Inline), Op]
        static int search(in byte src, int count, byte match)
        {
            for(var i=0; i<count; i++)
                if(Root.skip(src,i) == match)
                    return i;
            return NotFound;
        }
    

        [MethodImpl(Inline), Op]
        static int first(ReadOnlySpan<byte> src, byte match)
        {
            for(var i=0; i<src.Length; i++)
                if(Root.skip(src,i) == match)
                    return i;
            return NotFound;
        }

        /// <summary>
        /// Returns the index of the first source character that matches a target character
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="match">The character to match</param>
        [MethodImpl(Inline), Op]
        static int first(ReadOnlySpan<char> src, char match)
        {
            for(var i=0; i<src.Length; i++)
                if(Root.skip(src,i) == match)
                    return i;
            return NotFound;
        }        
    }
}