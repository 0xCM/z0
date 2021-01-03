//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct PartFiles : ITextual
    {
        const string FormatPattern = "{0}:{1} | {2}:{3} | {4}:{5}";

        public FS.Files Parsed {get;}

        public FS.Files Hex {get;}

        public FS.Files Asm {get;}

        [MethodImpl(Inline)]
        public PartFiles(FS.Files parsed, FS.Files hex, FS.Files asm)
        {
            Asm = asm;
            Hex = hex;
            Parsed = parsed;
        }

        [MethodImpl(Inline)]
        public string Format()
            => string.Format(FormatPattern, nameof(Parsed), Parsed.Count, nameof(Hex), Hex.Count, nameof(Asm), Asm.Count);

        public override string ToString()
            => Format();
    }
}