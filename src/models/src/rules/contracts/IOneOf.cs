//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static core;

    partial struct Rules
    {
        public interface IOneOf : ITerm
        {
            /// <summary>
            /// The number of possibilities
            /// </summary>
            uint Count {get;}

            /// <summary>
            /// Retrievies the possibilities
            /// </summary>
            /// <param name="dst">The target buffer</param>
            uint GetChoices(Span<dynamic> dst);
        }

        /// <summary>
        /// Characterizes a (possibly empty) sequence of choices
        /// </summary>
        /// <typeparam name="T">The choice type</typeparam>
        public interface IOneOf<T> : IOneOf
        {
            /// <summary>
            /// Specifies the possibilities
            /// </summary>
            Span<T> Choices {get;}

            uint IOneOf.Count
                => (uint)Choices.Length;

            uint IOneOf.GetChoices(Span<dynamic> dst)
            {
                var src =  Choices;
                var count = (uint)min(src.Length, dst.Length);
                for(var i=0; i<count; i++)
                    seek(dst,i) = skip(src,i);
                return count;
            }
        }
    }
}