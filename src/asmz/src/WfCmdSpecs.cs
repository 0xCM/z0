//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static WorkflowCommands;
    using static AsmWfCmdKind;

    public enum AsmWfCmdKind : byte
    {
        None = 0,

        ShowRexBits,

        DistillAsmStatements,

        ExportStokeImports,

        ShowSigOpTokens,

        ShowMnemonicSymbols,

        EmitApiClasses,

        EmitSymbolicLiterals,

        ShowAsmForms,

        EmitAsmForms,

        ShowEncodingKindNames,

        CorrelateApiCode,

        ShowCatalogSymbols,

        EmitResBytes,

        EmitImmSpecializations,

        CheckDigitParser,

        UpdateToolHelpIndex,
    }

    readonly struct AsmWfCmdSpecs
    {
        public static void RegisterCommands(IWfShell wf, App host, WfCmdIndex index)
        {
            index.Include(assign(ShowRexBits, host.ShowRexBits));
            index.Include(assign(DistillAsmStatements, host.DistillAsmStatements));
            index.Include(assign(ExportStokeImports, host.ExportStokeImports));
            index.Include(assign(ShowSigOpTokens, host.ShowSigOpTokens));
            index.Include(assign(ShowMnemonicSymbols, host.ShowMnemonicSymbols));
            index.Include(assign(EmitApiClasses, host.EmitApiClasses));
            index.Include(assign(EmitSymbolicLiterals, host.EmitSymbolicLiterals));
            index.Include(assign(ShowAsmForms, host.ShowAsmForms));
            index.Include(assign(EmitAsmForms, host.EmitAsmForms));
            index.Include(assign(ShowEncodingKindNames, host.ShowEncodingKindNames));
            index.Include(assign(CorrelateApiCode, host.CorrelateApiCode));
            index.Include(assign(ShowCatalogSymbols, host.ShowCatalogSymbols));
            index.Include(assign(EmitResBytes, host.EmitResBytes));
            index.Include(assign(EmitImmSpecializations, host.EmitImmSpecializations));
            index.Include(assign(CheckDigitParser, host.CheckDigitParser));
            index.Include(assign(UpdateToolHelpIndex, host.UpdateToolHelpIndex));
        }

        public static WfCmdIndex RegisterCommands(IWfShell wf, App host)
        {
            var dst = new WfCmdIndex();
            RegisterCommands(wf,host, dst);
            return dst;
        }

    }
}