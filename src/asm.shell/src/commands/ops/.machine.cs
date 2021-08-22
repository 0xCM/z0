//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".asmgen")]
        Outcome Generate(CmdArgs args)
        {
            var result = Outcome.Success;


            return result;
        }

        [CmdOp(".machine")]
        Outcome EmitMachineTables(CmdArgs args)
        {
            var result = Outcome.Success;
            var tables = Ws.Tables();
            var tokens = Wf.AsmTokens();

            result = EmitApiLiterals();
            if(result.Fail)
                return result;
            result = GenModRmBits();
            if(result.Fail)
                return result;

            result = GenSibBits();
            if(result.Fail)
                return result;

            EmitTokens(tokens.RegTokens());
            EmitTokens(tokens.OpCodeTokens());
            EmitTokens(tokens.SigTokens());
            EmitTokens(tokens.ConditonTokens());
            EmitTokens(tokens.PrefixTokens());
            EmitSymKinds(Symbols.index<AsmOpClass>(), tables.Table(WsAtoms.machine,"classes.asm.operands"));
            EmitSymIndex<RegClassCode>(tables.Table(WsAtoms.machine, "classes.asm.regs"));
            return result;
        }

        Outcome EmitApiLiterals()
        {
            var result = Outcome.Success;
            var components = ApiRuntimeLoader.assemblies();
            var providers = ApiLiterals.providers(components).View;
            var count = providers.Length;
            var buffer = list<ApiLiteralSpec>();
            var dst = ApiWs.Table<ApiLiterals>();
            for(var i=0; i<count; i++)
            {
                ref readonly var provider = ref skip(providers,i);
                var literals = ApiLiterals.provided(provider).View;
                for(var j=0; j<literals.Length; j++)
                {
                    ref readonly var literal = ref skip(literals,j);
                    buffer.Add(literal.Specify());
                }
            }

            TableEmit(buffer.ViewDeposited(), ApiLiteralSpec.RenderWidths, dst);

            return result;
        }

        Outcome GenSibBits()
        {
            var result = Outcome.Success;
            var dst = TableWs().Path(WsAtoms.machine, "sib", FS.ext("bits") + FS.Csv);
            var rows = AsmBits.SibRows().View;
            TableEmit(rows, SibBitfieldRow.RenderWidths, dst);
            return result;
        }

        Outcome GenModRmBits()
        {
            var path = TableWs().Path(WsAtoms.machine, "modrm", FS.ext("bits") + FS.Csv);
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
            var dst = Ws.Tables().Table<SymToken>(WsAtoms.machine, src.Name);
            var tokens = Symbols.tokens(src.Types());
            TableEmit(tokens, SymToken.RenderWidths, dst);
        }

        ReadOnlySpan<SymLiteralRow> EmitSymLiterals<E>(FS.FilePath dst)
            where E : unmanaged, Enum
        {
            var svc = Wf.Symbolism();
            return svc.EmitLiterals<E>(dst);
        }
    }
}