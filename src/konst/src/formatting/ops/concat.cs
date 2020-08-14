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
        
    partial struct Render
    {
        [Op]
        public static string concat(ReadOnlySpan<string> src, char? delimiter)
        {
            var dst = text.build();
            for(var i=0; i<src.Length; i++)
            {
                if(i != 0 && delimiter != null)
                    dst.Append(delimiter.Value);                
                dst.Append(src[i]);            
            }
            return dst.ToString();
        }

        [Op]
        public static string concat(ReadOnlySpan<string> src, string delimiter)
        {
            var dst = text.build();
            for(var i=0; i<src.Length; i++)
            {
                if(i != 0 && delimiter != null)
                    dst.Append(delimiter);                
                dst.Append(src[i]);            
            }
            return dst.ToString();
        }
    }
}