//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class Nasm
    {
        public Index<NasmInstruction> ParseInstuctionAssets()
        {
            var lines = text.lines(Parts.AsmCore.Assets.NasmInstructions().ViewText()).View;
            var count = lines.Length;
            var section = EmptyString;
            var records = RecordList.create<NasmInstruction>(7000);
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
    }
}