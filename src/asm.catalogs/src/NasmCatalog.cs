//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.InteropServices;

    using static Root;
    using static core;

    public class NasmCatalog : AppService<NasmCatalog>
    {
        [Record(TableId), StructLayout(LayoutKind.Sequential)]
        public struct NasmInstruction : IRecord<NasmInstruction>
        {
            public const string TableId = "nasm.instructions";

            public uint LineNumber;

            public CharBlock16 Mnemonic;

            public TextBlock Operands;

            public TextBlock Encoding;

            public TextBlock Flags;
        }

        public Index<NasmInstruction> ParseInstuctionAssets()
        {
            var lines = text.lines(Parts.AsmCatalogs.Assets.NasmInstructions().Utf8()).View;
            var count = lines.Length;
            var section = EmptyString;
            var records = DataList.create<NasmInstruction>(7000);
            for(var i=0; i<count; i++)
            {
                ref readonly var line = ref skip(lines,i);
                var trimmed = line.Trim().Text.Replace(Chars.Pipe,Chars.Caret);

                // No content
                if(trimmed.Length < 2)
                    continue;

                // Comments/headers
                if(trimmed[0] == Chars.Semicolon)
                    continue;

                var dst = new NasmInstruction();
                dst.LineNumber = line.LineNumber;
                dst.Mnemonic = trimmed.LeftOfFirst(Chars.Tab);
                dst.Operands = trimmed.RightOfFirst(Chars.Tab).LeftOfFirst(Chars.LBracket).Trim().Replace(Chars.Tab,Chars.Space);
                dst.Encoding = string.Format("[{0}]", trimmed.Between(Chars.LBracket, Chars.RBracket).Replace(Chars.Tab, Chars.Space));
                dst.Flags = trimmed.RightOfFirst(Chars.RBracket).Trim().Replace(Chars.Tab, Chars.Space);
                var j=0;
                records.Add(dst);
            }

            return records.Emit();
        }

        public Index<NasmInstruction> EmitInstructionCatalog(FS.FilePath dst)
        {
            var src = ParseInstuctionAssets();
            var count = src.Length;
            if(count != 0)
            {
                var flow = Wf.EmittingTable<NasmInstruction>(dst);
                var emitted = Tables.emit(src.View, dst);
                Wf.EmittedTable(flow, emitted);
                return src;
            }
            else
                return Index<NasmInstruction>.Empty;
        }

        public Index<NasmInstruction> EmitInstructionCatalog()
            => EmitInstructionCatalog(Db.CatalogTable<NasmInstruction>("asm"));
    }
}