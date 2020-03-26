//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Components)]

namespace Z0.Parts
{        
    public sealed class Components : Part<Components>
    {


    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using static Components;

    public static partial class ComponentOps
    {

    }

    public static class Components
    {
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        [MethodImpl(Inline)]
        internal static int bitsize<T>()            
            where T : unmanaged
                => Unsafe.SizeOf<T>()*8;

        /// <summary>
        /// If the source type is a type reference, returns the referenced type; otherwise, returns the original type
        /// </summary>
        /// <param name="src">The type to examine</param>
        internal static Type EffectiveType(this Type src)
            => src.UnderlyingSystemType.IsByRef ? src.GetElementType() : src;


        [MethodImpl(Inline)]
        public static IEnumerable<T> seq<T>(params T[] src)
            => src;

        /// <summary>
        /// Creates a stream of replicated characters 
        /// </summary>
        /// <param name="src">The character to replicate</param>
        /// <param name="count">The replication count</param>
        public static IEnumerable<char> replicate(char src, int count)
            => new string(src,count);

        public static IEnumerable<string> replicate(string src, int count)
        {
            for(var i=0; i<count; i++)
                yield return src;
        }

        /// <summary>
        /// Creates a new stringbuilder
        /// </summary>
        static StringBuilder build()
            => new StringBuilder();

        /// <summary>
        /// Creates a new string by weaving a specified character between each character in the source
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="c">The character to intersperse</param>
        public static string intersperse(string src, char c)
        {
            var builder = build();
            foreach(var item in src)
            {
                builder.Append(item);
                builder.Append(c);
            }
            return builder.ToString();
        }

        /// <summary>
        /// Creates a new string by weaving a substring between each character in the source
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="sep">The value to intersperse</param>
        public static string intersperse(string src, string sep)
        {
            var builder = build();
            foreach(var item in src)
            {
                builder.Append(item);
                builder.Append(sep);
            }
            return builder.ToString();
        }

    }
}