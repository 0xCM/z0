//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;

    public class NasmCatalog : AppService<NasmCatalog>
    {
        AsmWorkspace Workspace;

        protected override void Initialized()
        {
            Workspace = Wf.AsmWorkspace();

        }

        static bool comment(string src)
            => src.Length > 0 && src[0] == Chars.Semicolon;

        static ReadOnlySpan<char> encoding(ReadOnlySpan<char> src)
            => text.replace(text.between(src, Chars.LBracket, Chars.RBracket), Chars.Tab,Chars.Space).Trim();

        static ReadOnlySpan<char> operands(ReadOnlySpan<char> src)
        {
            var i0 = text.index(src,Chars.Tab, Chars.Space);
            if(i0 >0)
            {
                var i1 = text.index(src, i0 + 1, Chars.LBracket);
                if(i1 >0)
                    return text.segment(src,i0 + 1, i1 - 1).Trim();
            }
            return default;
        }

        public ReadOnlySpan<NasmInstruction> ParseSource()
        {
            const uint FirstLine = 70;
            var src = Workspace.DataSource("nasm-instructions", FS.Txt);
            var lines = slice(src.ReadTextLines(), FirstLine);
            var count = lines.Length;
            var section = EmptyString;
            var buffer = span<NasmInstruction>(count);
            var j = 0u;
            var widths = NasmInstruction.RenderWidths;
            for(var i=0; i<count; i++)
            {
                ref readonly var line = ref skip(lines,i);
                var content = line.Trim().Text.Replace(Chars.Pipe, Chars.Caret);

                if(content.Length < 2)
                    continue;

                if(comment(content))
                    continue;

                ref var dst = ref seek(buffer,j++);
                var pad = z16;
                dst.Sequence = j;
                dst.Mnemonic = text.absolute(content.LeftOfFirst(Chars.Tab), skip(widths,1));
                dst.Operands = text.absolute(text.format(operands(content)), skip(widths,2));
                dst.Encoding = text.absolute(text.format(encoding(content)), skip(widths,3));
                var flags = content.RightOfFirst(Chars.RBracket).Trim().Replace(Chars.Tab, Chars.Space);
                dst.Flags = text.absolute(flags, skip(widths,4));
            }

            return slice(buffer, 0, j);
        }

        public ReadOnlySpan<NasmInstruction> ImportInstructions(FS.FilePath dst)
        {
            var src = ParseSource();
            var count = src.Length;
            if(count != 0)
            {
                var flow = Wf.EmittingTable<NasmInstruction>(dst);
                var emitted = Tables.emit(src, dst, NasmInstruction.RenderWidths);
                Wf.EmittedTable(flow, emitted);
                return src;
            }
            else
                return default;
        }

        public ReadOnlySpan<NasmInstruction> ImportInstructions()
            => ImportInstructions(Workspace.ImportTable<NasmInstruction>());
    }
}