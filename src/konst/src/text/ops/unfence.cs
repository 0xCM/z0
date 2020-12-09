//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static TextRules;

    partial class text
    {
        /// <summary>
        /// If bracketed, extracts the enclosed content; otherwise, returns the empty string
        /// </summary>
        /// <param name="src">The source text</param>
        [Op]
        public static string unbracket(string src)
            => Parse.unbracket(src);

        /// <summary>
        /// Extracts text that is enclosed between left and right boundaries, i.e. {left}{content}{right} => {content}
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="left">The left boundary</param>
        /// <param name="right">The right boundary</param>
        [Op]
        public static string unfence(string src, char left, char right)
            => Parse.unfence(src, left, right);

        /// <summary>
        /// Extracts text that is enclosed between left and right boundaries, i.e. {left}{content}{right} => {content}
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="left">The left boundary</param>
        /// <param name="right">The right boundary</param>
        [Op]
        public static string unfence(string src, string left, string right)
            => Parse.unfence(src, left, right);

    }
}