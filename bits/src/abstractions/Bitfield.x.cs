//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class BitFieldX
    {

        public static string Format(this BitField64 src)
        {
            var fmt = text();
            var count = src.Spec.FieldCount;
            var spec = src.Spec;
            for(var i = count - 1; i>= 0; i--)
            {
                fmt.Append(src[i].FormatBits(spec[i].Width));
                if(i != 0)
                    fmt.Append(AsciSym.Underscore);
            }
            return fmt.ToString();
        }


    }

}