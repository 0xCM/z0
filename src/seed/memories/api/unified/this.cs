//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Memories
    {
        [MethodImpl(Inline), Op]
        public static string ThisMember([CallerMemberName] string name = null)
            => name ?? string.Empty;

        [MethodImpl(Inline), Op]
        public static string ThisFile([CallerFilePath] string path = null)
            => path ?? string.Empty;

        [MethodImpl(Inline), Op]
        public static int ThisLine([CallerLineNumber] int? line = null)
            => line ?? 0;    
    }
}