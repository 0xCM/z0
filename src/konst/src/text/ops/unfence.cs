//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class text
    {
        /// <summary>
        /// If bracketed, extracts the enclosed content; otherwise, returns the empty string
        /// </summary>
        /// <param name="src">The source text</param>
        public static string unbracket(string src)
            => unfence(src, Chars.LBracket,Chars.RBracket);

        /// <summary>
        /// If fenced with specified left and right characters, extracts the enclosed content; otherwise, returns the content unmolested
        /// </summary>
        /// <param name="src">The putative fenced content</param>
        public static string unfence(string src, char left, char right)
        {
            if(blank(src))
                return string.Empty;

            if(!fenced(src,left,right))
                return src;
                
            var data = src.Trim();
            var length = data.Length;
            return data.Substring(1, length - 2);
        }
    }
}