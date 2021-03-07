//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
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

        ShowAsmCatForms,

        EmitAsmCatForms,

        ShowEncodingKindNames,

        CorrelateApiCode,

        ShowCatalogSymbols,

        EmitResBytes,

        EmitImmSpecializations,

        CheckDigitParser,

        ShowSigOpSymbols,

        ShowSigOpComposites,
    }
}