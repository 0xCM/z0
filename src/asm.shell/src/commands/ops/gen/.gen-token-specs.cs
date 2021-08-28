//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;
    using static WsAtoms;

    partial class AsmCmdService
    {
        [CmdOp(".gen-token-specs")]
        Outcome GenTokenSpecs(CmdArgs args)
        {
            var result = Outcome.Success;
            var symbols = Symbols.index<AsmOpCodeTokens.ModRmToken>();
            var src = Z0.Tokens.concat(symbols);
            var dst = Ws.Gen().Root + FS.file("token-specs", FS.Cs);
            EmitTokenSpecs("ModRmTokens", src,dst);
            return result;
        }

        [CmdOp(".bitfields")]
        Outcome GenBitFields(CmdArgs args)
        {
            var result = Outcome.Success;
            var dir = Ws.Tables().Subdir(llvm) + FS.folder(lists);
            var name = "BinOpMI";
            var file = FS.file(name, FS.Csv);
            var formatter = Tables.formatter<ListItem>(ListItem.RenderWidths);
            if(Tables.list(dir + file, out var records))
            {
                var src = @readonly(records);
                var count = src.Length;
                var segs = alloc<BitfieldSeg>(count);

                for(var i=0u; i<count; i++)
                {
                    ref readonly var item = ref skip(src,i);
                    seek(segs,i) = BitfieldSpecs.segment(item.Value.Format(), i, i, 1);
                }

                var bitfield = BitfieldSpecs.bitfield(name,segs);
                Write(bitfield.Format());

            }

            return result;
        }

        [CmdOp(".tokenstrings")]
        Outcome EmitTokenStrings(CmdArgs args)
        {
            // "----\0----\0----\0"
            var result = Outcome.Success;
            var dst = text.buffer();
            var spec = new char[12];
            var j=0u;
            seek(spec,j++) = Chars.Dash;
            seek(spec,j++) = Chars.Dash;
            seek(spec,j++) = Chars.Dash;
            seek(spec,j++) = Chars.Null;

            seek(spec,j++) = Chars.Dash;
            seek(spec,j++) = Chars.Dash;
            seek(spec,j++) = Chars.Dash;
            seek(spec,j++) = Chars.Null;

            seek(spec,j++) = Chars.Dash;
            seek(spec,j++) = Chars.Dash;
            seek(spec,j++) = Chars.Dash;
            seek(spec,j++) = Chars.Null;

            var ts = TokenStrings.define(spec);
            Write(ts.TokenCount);

            return result;
        }

        void EmitTokenSpecs(string name, ReadOnlySpan<AsciCode> src, FS.FilePath dst)
        {
            var emitting = EmittingFile(dst);
            using var writer = dst.AsciWriter();
            var i=0;
            var count = src.Length;
            var buffer = text.buffer();
            writer.Write(string.Format("public const string {0} = ", name));
            writer.Write('\"');
            while(i++<count)
            {
                ref readonly var c = ref skip(src,i);
                if(c == AsciCode.Null)
                {
                    writer.Write('\\');
                    writer.Write('0');
                }
                else
                    writer.Write((char)c);
            }
            writer.Write('\"');
            writer.Write(';');
            writer.WriteLine();

            EmittedFile(emitting, 1);
        }
    }
}