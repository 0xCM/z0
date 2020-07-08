//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    using static Konst;

    partial struct core
    {
        /// <summary>
        /// Allocates a caller-disposed stream over a string
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="encoding">The text encoding</param>
        public static MemoryStream stream(string src, Encoding encoding = null)
        {
            var bytes = (encoding ?? Encoding.UTF8).GetBytes(src ?? string.Empty);            
            return new MemoryStream(bytes);
        }
    }
}