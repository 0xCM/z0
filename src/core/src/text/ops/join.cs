//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct TextTools
    {
        public static string join(Span<string> src, string sep)
        {
            var dst = buffer();
            for(var i=0; i<src.Length; i++)
            {
                ref var cell = ref src[i];
                if(i != src.Length - 1)
                    dst.Append($"{cell}{sep}");
                else
                    dst.Append(cell);
            }
            return dst.ToString();
        }
    }
}