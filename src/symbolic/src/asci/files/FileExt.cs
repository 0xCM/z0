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
    /// Defines an asci4 file extension
    /// </summary>
    public readonly struct FileExt
    {
        public asci4 Name {get;}
        
        /// <summary>
        /// Defines a file extension of length 4 or less - and should not include a leading '.'
        /// </summary>
        /// <param name="src">The extension name</param>
        [MethodImpl(Inline)]
        public static FileExt Define(string src)
            => new FileExt(src);

        [MethodImpl(Inline)]
        public FileExt(asci4 name)
        {
            Name = name;
        }
    }
}