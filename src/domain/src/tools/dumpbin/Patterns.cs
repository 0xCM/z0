//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static AsciCharText;
    using static DumpBin.Flag;

    using X = ArchiveFileKinds;


    public partial struct DumpBin
    {
        [LiteralProvider]
        public readonly struct Patterns
        {
            [StringLiteral]
            const string HeadersLiteral = ToolName + Space
                + FlagPrefix + nameof(HEADERS) + Space
                + FlagPrefix + nameof(OUT) + FlagDelimiter + RP.Slot1 + Space
                + RP.Slot0;

            public static CmdPattern Headers
                => Cmd.pattern(nameof(HeadersLiteral), HeadersLiteral);

            public static FS.FileExt HeadersExt
                => ext(HEADERS) + X.Log;

            [StringLiteral]
            const string DisasmLiteral = ToolName + Space
                + FlagPrefix + nameof(DISASM) + Space
                + FlagPrefix + nameof(OUT) + FlagDelimiter + RP.Slot1 + Space
                + RP.Slot0;

            public static CmdPattern Disasm
                => Cmd.pattern(nameof(DisasmLiteral), DisasmLiteral);

            public static FS.FileExt DisasmExt
                => ext(DISASM) + X.Asm;

            [StringLiteral]
            const string ExportsLiteral = ToolName + Space
                + FlagPrefix + nameof(EXPORTS) + Space
                + FlagPrefix + nameof(OUT) + FlagDelimiter + RP.Slot1 + Space
                + RP.Slot0;

            public static CmdPattern Exports
                => Cmd.pattern(nameof(ExportsLiteral), ExportsLiteral);

            public static FS.FileExt ExportsExt
                => ext(EXPORTS) + X.Log;

            [StringLiteral]
            const string DisasmAsmOnly = ToolName + Space
                + FlagPrefix + nameof(DISASM) + ArgSpecifier + nameof(NOBYTES)
                + FlagPrefix + nameof(OUT) + FlagDelimiter + RP.Slot1 + Space
                + RP.Slot0;

            public static FS.FileExt DisasmAsmOnlyExt
                => ext(DISASM) + Z0.FS.ext(nameof(NOBYTES));

            public static CmdPattern DisasmAsmOnlyPattern
                => Cmd.pattern(nameof(DisasmAsmOnly), DisasmAsmOnly);

            public static FS.FileExt ext(Flag f)
                => Z0.FS.ext(f.ToString().ToLower());

            public static FS.FileExt ext(Flag f1, Flag f2)
                => Z0.FS.ext(f1.ToString().ToLower(), f2.ToString().ToLower());
        }
    }
}