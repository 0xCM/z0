//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;

    using System.Runtime.CompilerServices;

    using static z;
    using static Part;



    public partial struct llvm
    {

            [MethodImpl(Inline), Op]
            public static bool decode(byte src, out char dst)
            {
                const string Chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789._";

                if((src & ~63) == 0)
                    dst = skip(span(Chars), src);
                else
                    dst = '\0';

                return dst != '\0';
            }
    }
}