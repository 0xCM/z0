//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class AsciCodes     
    {
        [MethodImpl(Inline), Op]
        public static string format(AsciCode src)
            => new string(new char[1]{(char)src.Code});

        [MethodImpl(Inline), Op]
        public static string format(AsciCode2 src)
        {
            Span<char> dst = stackalloc char[2];
            chars(src,dst);
            return new string(dst);
        }

        [MethodImpl(Inline), Op]
        public static string format(AsciCode4 src)
        {
            Span<char> dst = stackalloc char[4];
            chars(src,dst);
            return new string(dst);
        }

        [MethodImpl(Inline), Op]
        public static string format(AsciCode8 src)
        {
            Span<char> dst = stackalloc char[8];
            chars(src,dst);
            return new string(dst);
        }

        [MethodImpl(Inline), Op]
        public static string format(AsciCode16 src)
            => new string(chars(src));
    }
}