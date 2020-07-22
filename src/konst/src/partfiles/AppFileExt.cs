//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines widely-used file extensions and a basic extension api
    /// </summary>
    [ApiHost]
    public readonly struct AppFileExt
    {
        public static AppFileExt Service => default;
        
        /// <summary>
        /// Defines a file extension of length 4 or less - and should not include a leading '.'
        /// </summary>
        /// <param name="src">The extension name</param>
        [MethodImpl(Inline), Op]
        public static FileExt Ext(string src)
            => new FileExt(src);
    }
}