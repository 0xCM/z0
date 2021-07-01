//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly partial struct Rules
    {
        [MethodImpl(Inline)]
        public static string enclose<S,T>(S content, Fence<T> fence)
            => RP.adjacent(fence.Left, content, fence.Right);

        /// <summary>
        /// Encloses text within a bounding string
        /// </summary>
        /// <param name="content">The text to enclose</param>
        /// <param name="sep">The left and right boundary</param>
        [MethodImpl(Inline), Op]
        public static string enclose(object content, string sep)
            => string.Concat(sep,$"{content}",sep);

        const NumericKind Closure = UnsignedInts;

         public static string FormatPattern(VarContextKind vck)
            => VarContextKinds.FormatPattern(vck);

        [Op]
        public static bool parse(string src, Bounded<int> bounds, out int dst, out Outcome outcome)
        {
            outcome = NumericParser.parse(src, out dst);
            if(!outcome)
                return false;

            if(!satisfied(bounds,dst))
            {
                outcome = (false, $"The parsed value {dst} is not with the required range {bounds}");
                return false;
            }
            return true;
        }
    }
}