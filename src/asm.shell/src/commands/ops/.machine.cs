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
        [CmdOp(".machine")]
        Outcome EmitMachineTables(CmdArgs args)
        {
            var result = Outcome.Success;
            var tables = Ws.Tables();
            var tokens = Wf.AsmTokens();

            var dir = Ws.Tables().Subdir(machine);

            Emitters.Emit(Loaders.ApiLiterals().View, dir);
            result = GenModRmBits();
            if(result.Fail)
                return result;

            result = GenSibBits();
            if(result.Fail)
                return result;

            result = AsmTables.ImportCpuIdSources();
            if(result.Fail)
                return result;

            Wf.IntelIntrinsics().Emit(dir);

            EmitTokens(tokens.RegTokens());
            EmitTokens(tokens.OpCodeTokens());
            EmitTokens(tokens.SigTokens());
            EmitTokens(tokens.ConditonTokens());
            EmitTokens(tokens.PrefixTokens());
            EmitSymKinds(Symbols.index<AsmOpClass>(), tables.TablePath(machine,"classes.asm.operands"));
            EmitSymIndex<RegClassCode>(tables.TablePath(machine, "classes.asm.regs"));
            return result;
        }

        Outcome GenSibBits()
        {
            var result = Outcome.Success;
            var dst = Ws.Tables().Path(machine, "sib", FS.ext("bits") + FS.Csv);
            var rows = AsmBits.SibRows().View;
            TableEmit(rows, SibBitfieldRow.RenderWidths, dst);
            return result;
        }

        Outcome GenModRmBits()
        {
            var path = Ws.Tables().Path(machine, "modrm", FS.ext("bits") + FS.Csv);
            var flow = Wf.EmittingFile(path);
            using var writer = path.AsciWriter();
            var dst = span<char>(256*128);
            var count = AsmBits.ModRmTable(dst);
            var rendered = slice(dst,0,count);
            writer.Write(rendered);
            Wf.EmittedFile(flow,count);
            return true;
        }

        void EmitTokens(ITokenSet src)
        {
            var dst = Ws.Tables().TablePath<TokenRow>(machine, src.Name);
            var tokens = Tokens.rows(src.Types());
            TableEmit(tokens, TokenRow.RenderWidths, dst);
        }

        ReadOnlySpan<SymLiteralRow> EmitSymLiterals<E>(FS.FilePath dst)
            where E : unmanaged, Enum
        {
            var svc = Wf.Symbolism();
            return svc.EmitLiterals<E>(dst);
        }
    }
}