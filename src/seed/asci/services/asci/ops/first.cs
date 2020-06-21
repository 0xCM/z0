//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    partial struct asci
    {        
        [MethodImpl(Inline), Op]
        public static int first(in asci4 src, byte match)
            => first(bytes(src), match);

        [MethodImpl(Inline), Op]
        public static int first(in asci5 src, byte match)
            => first(bytes(src), match);

        [MethodImpl(Inline), Op]
        public static int first(in asci8 src, byte match)
            => first(bytes(src), match);

        [MethodImpl(Inline), Op]
        public static int first(in asci16 src, byte match)
            => first(bytes(src), match);

        [MethodImpl(Inline), Op]
        public static int first(in asci32 src, byte match)
            => first(bytes(src), match);

        [MethodImpl(Inline), Op]
        public static int first(in asci64 src, byte match)
            => first(bytes(src), match);         

        [MethodImpl(Inline), Op]
        static int first(ReadOnlySpan<byte> src, byte match)
        {
            for(var i=0; i<src.Length; i++)
                if(Root.skip(src,i) == match)
                    return i;
            return -1;
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
            return -1;
        }        
    }
}