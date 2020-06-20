//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    partial struct asci
    {        
        /// <summary>
        /// Counts the number of characters that precede a null terminator, if any
        /// </summary>
        /// <param name="src">The asci source</param>
        [MethodImpl(Inline), Op]
        public static int length(in asci2 src)
            => IndexLength(first(src, AsciNone), src.MaxLength);

        /// <summary>
        /// Counts the number of characters that precede a null terminator, if any
        /// </summary>
        /// <param name="src">The asci source</param>
        [MethodImpl(Inline), Op]
        public static int length(in asci4 src)
            => IndexLength(first(src, AsciNone), src.MaxLength);

        /// <summary>
        /// Counts the number of characters that precede a null terminator, if any
        /// </summary>
        /// <param name="src">The asci source</param>
        [MethodImpl(Inline), Op]
        public static int length(in asci5 src)
            => IndexLength(first(src, AsciNone), src.MaxLength);

        /// <summary>
        /// Counts the number of characters that precede a null terminator, if any
        /// </summary>
        /// <param name="src">The asci source</param>
        [MethodImpl(Inline), Op]
        public static int length(in asci8 src)
            => IndexLength(first(src, AsciNone), src.MaxLength);

        /// <summary>
        /// Counts the number of characters that precede a null terminator, if any
        /// </summary>
        /// <param name="src">The asci source</param>
        [MethodImpl(Inline), Op]
        public static int length(in asci16 src)
            => IndexLength(first(src, AsciNone), src.MaxLength);

        /// <summary>
        /// Counts the number of characters that precede a null terminator, if any
        /// </summary>
        /// <param name="src">The asci source</param>
        [MethodImpl(Inline), Op]
        public static int length(in asci32 src)
            => IndexLength(first(src, AsciNone), src.MaxLength);

        /// <summary>
        /// Counts the number of characters that precede a null terminator, if any
        /// </summary>
        /// <param name="src">The asci source</param>
        [MethodImpl(Inline), Op]
        public static int length(in asci64 src)
            => IndexLength(first(src, AsciNone), src.MaxLength);        
            
        [MethodImpl(Inline)]
        internal static bool IndexFound(int i)
            => i != NotFound;

        [MethodImpl(Inline)]
        internal static int IndexLength(int i, int max)
            => IndexFound(i) ? i + 1 : max;

    }
}