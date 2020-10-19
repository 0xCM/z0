//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.IO;

    using static Konst;
    using static z;

    partial class text
    {
        /// <summary>
        /// Allocates a stream over a string
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="encoding">The text encoding</param>
        [Op]
        public static MemoryStream stream(string src, Encoding encoding = null)
        {
            var bytes = (encoding ?? Encoding.UTF8).GetBytes(src ?? string.Empty);            
            return new MemoryStream(bytes);
        }
    }
}