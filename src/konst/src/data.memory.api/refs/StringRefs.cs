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
    
    partial struct StringRefs
    {
        /// <summary>
        /// Formats the source argument according to a specified format pattern
        /// </summary>
        /// <param name="pattern">The format pattern</param>
        /// <param name="arg0">The pattern argument</param>
        [MethodImpl(Inline), Op]
        public static string format(in StringRef pattern, in StringRef arg0)
            => text.format(pattern.Format(), arg0.Format());

        /// <summary>
        /// Formats the source arguments according to a specified format pattern
        /// </summary>
        /// <param name="pattern">The format pattern</param>
        /// <param name="arg0">The first pattern argument</param>
        /// <param name="arg0">The second pattern argument</param>
        [MethodImpl(Inline), Op]
        public static string format(in StringRef pattern, in StringRef arg0, in StringRef arg1)
            => text.format(pattern.Format(), arg0.Format(), arg1.Format());

        /// <summary>
        /// Formats the source arguments according to a specified format pattern
        /// </summary>
        /// <param name="pattern">The format pattern</param>
        /// <param name="arg0">The first pattern argument</param>
        /// <param name="arg0">The second pattern argument</param>
        [MethodImpl(Inline), Op]
        public static string format(string pattern, in StringRef arg0, in StringRef arg1)
            => text.format(pattern, arg0, arg1.Format());

        /// <summary>
        /// Formats the source arguments according to a specified format pattern
        /// </summary>
        /// <param name="pattern">The format pattern</param>
        /// <param name="arg0">The first pattern argument</param>
        /// <param name="arg0">The second pattern argument</param>
        [MethodImpl(Inline), Op]
        public static string format(string pattern, in string arg0, in StringRef arg1)
            => text.format(pattern, arg0, arg1.Format());

        /// <summary>
        /// Formats the source arguments according to a specified format pattern
        /// </summary>
        /// <param name="pattern">The format pattern</param>
        /// <param name="arg0">The first pattern argument</param>
        /// <param name="arg1">The second pattern argument</param>
        /// <param name="arg2">The third pattern argument</param>
        [MethodImpl(Inline), Op]
        public static string format(in StringRef pattern, in StringRef arg0, in StringRef arg1, in StringRef arg2)
            => text.format(pattern.Format(), arg0.Format(), arg1.Format(), arg2.Format());
    }
}