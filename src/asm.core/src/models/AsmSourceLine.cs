//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct AsmSourceLine
    {
        CharBlock256 Storage;

        [MethodImpl(Inline)]
        public AsmSourceLine(string src)
        {
            Storage = src;
        }

        public string Format()
            => Storage.Format();
    }
}