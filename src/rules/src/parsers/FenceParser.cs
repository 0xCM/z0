//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Rules;
    using static core;

    using SQ = SymbolicQuery;

    public readonly struct FenceParser : IParseFunction<string>
    {
        /// <summary>
        /// Extracts text that is enclosed between left and right boundaries, i.e. {left}{content}{right} => {content}
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="left">The left boundary</param>
        /// <param name="right">The right boundary</param>
        [Op]
        public static bool unfence(string src, Fence<char> fence, out string dst)
        {
            dst = EmptyString;
            if(!SQ.blank(src) && SQ.fenced(src, fence, out var location))
            {
                dst = text.segment(src, location.Left + 1,  location.Right - 1);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Extracts text that is enclosed between left and right boundaries, i.e. {left}{content}{right} => {content}
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="left">The left boundary</param>
        /// <param name="right">The right boundary</param>
        [Op]
        public static string unfence(string src, Fence<string> fence)
        {
            (var i0, var i1) = SQ.indices(src, fence);
            if(i0 != NotFound && i1 != NotFound &&(i0 < i1))
            {
                var start = i0 + fence.Left.Length;
                var length = i1 - start;
                return text.slice(src, start, length);
            }

            return EmptyString;
        }

        readonly Fence<char> Fence;

        [MethodImpl(Inline)]
        public FenceParser(Fence<char> fence)
        {
            Fence = fence;
        }

        public Outcome Parse(string src, out string dst)
        {
            var result = Outcome.Success;
            dst = EmptyString;
            if(nonempty(src))
                result = unfence(src,Fence, out dst);
            else
                result = (false, EmptyInput);
            return result;
        }

        static string EmptyInput => "The input was empty";
    }
}
