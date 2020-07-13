//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;

    readonly struct PathChars
    {
        public static char[] FileNameChars
        {
            [MethodImpl(Inline)]
            get => Path.GetInvalidFileNameChars();
        }

        public static char[] FilePathChars
        {
            [MethodImpl(Inline)]
            get => Path.GetInvalidPathChars();
        }
    }
}