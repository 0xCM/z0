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
        
        public static FileExt Asm 
        {
            [MethodImpl(Inline)]
            get => Ext("asm");
        }

        public static FileExt Csv 
        {
            [MethodImpl(Inline)]
            get => Ext("csv");
        }

        public static FileExt Hex 
        {
            [MethodImpl(Inline)]
            get => Ext("hex");
        }

        public static FileExt Txt 
        {
            [MethodImpl(Inline)]
            get => Ext("txt");
        }

        public static FileExt Log 
        {
            [MethodImpl(Inline)]
            get => Ext("log");
        }

        /// <summary>
        /// Defines a file extension of length 4 or less - and should not include a leading '.'
        /// </summary>
        /// <param name="src">The extension name</param>
        [MethodImpl(Inline), Op]
        public static FileExt Ext(string src)
            => new FileExt(src);

        /// <summary>
        /// Defines a file extension of length 8 or or less - and should not include a leading '.'
        /// </summary>
        /// <param name="src">The extension name</param>
        [MethodImpl(Inline), Op]
        public FileExt<asci8> Ext(N8 n, string src)
            => new FileExt<asci8>(src);

        /// <summary>
        /// Defines a file extension of length 16 or or less - and should not include a leading '.'
        /// </summary>
        /// <param name="src">The extension name</param>
        [MethodImpl(Inline), Op]
        public FileExt<asci16> Ext(N16 n, string src)
            => new FileExt<asci16>(src);
    }
}