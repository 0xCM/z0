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
        public FS.Files Raw {get;}

        public FS.Files Parsed {get;}

        public FS.Files Hex {get;}

        public FS.Files Asm {get;}

        public FS.Files ImmHex {get;}

        public FS.Files ImmAsm {get;}

        [MethodImpl(Inline)]
        public PartFiles(FS.Files raw, FS.Files parsed, FS.Files hex, FS.Files asm, FS.Files immhex, FS.Files immasm)
        {
            Raw = raw;
            Asm = asm;
            Hex = hex;
            Parsed = parsed;
            ImmHex = immhex;
            ImmAsm = immasm;
        }

        [MethodImpl(Inline)]
        public string Format()
            => string.Format(RP.Property6,
                nameof(Raw), Raw.Count,
                nameof(Parsed), Parsed.Count,
                nameof(Hex), Hex.Count,
                nameof(Asm), Asm.Count,
                nameof(ImmHex), ImmHex.Count,
                nameof(ImmAsm), ImmAsm.Count
                );

        public override string ToString()
            => Format();
    }
}