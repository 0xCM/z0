//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Text;

    using static zfunc;

    using static As;

    public static class FieldSegments
    {
        //(byte)(endpos - startpos + 1)
        
        /// <summary>
        /// Defines a bitfield segment
        /// </summary>
        /// <param name="name">The segment name</param>
        /// <param name="index">The segment index</param>
        /// <param name="startpos">The position of the first bit in the segment</param>
        /// <param name="endpos">The position of the last bit in the segment</param>
        [MethodImpl(Inline)]
        public static FieldSegment define(string name, byte index, byte startpos, byte endpos, byte width)
            => new FieldSegment(name,index, startpos, endpos, width);

        /// <summary>
        /// Defines a bitfield segment
        /// </summary>
        /// <param name="name">The segment name</param>
        /// <param name="index">The segment index</param>
        /// <param name="startpos">The position of the first bit in the segment</param>
        /// <param name="endpos">The position of the last bit in the segment</param>
        [MethodImpl(Inline)]
        public static FieldSegment<T> define<T>(string name, T index, T startpos, T endpos, T width)
            where T : unmanaged
                => new FieldSegment<T>(name, index, startpos, endpos, width);

        /// <summary>
        /// Computes the canonical segment format
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <typeparam name="T">The type over which the segment is defined</typeparam>
        public static string format<T>(IFieldSegment<T> src)
            where T : unmanaged
                => $"{src.Name}({src.Index}, {src.Width}:{src.StartPos}..{src.EndPos})";

        /// <summary>
        /// Computes the canonical format for a contiguous field segment sequence
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <typeparam name="T">The type over which the segment is defined</typeparam>
        public static string format<S,T>(ReadOnlySpan<S> src)
            where T : unmanaged
            where S : IFieldSegment<T>
        {
            var sep =$"{AsciSym.Comma}{AsciSym.Space}";            
            var formatted = new StringBuilder();
            formatted.Append(AsciSym.LBracket);
            for(var i=0; i< src.Length; i++)
            {
                formatted.Append(format(src[(byte)i]));
                if(i != src.Length - 1)
                    formatted.Append(sep);
            }

            formatted.Append(AsciSym.RBracket);            
            return formatted.ToString();
        }

        public static string format(ReadOnlySpan<FieldSegment> src)
            => format<FieldSegment,byte>(src);

        public static string format<T>(ReadOnlySpan<FieldSegment<T>> src)
            where T : unmanaged
                => format<FieldSegment<T>,T>(src);
    }
}