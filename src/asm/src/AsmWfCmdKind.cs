//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [CommandKind]
    public enum AsmWfCmdKind : byte
    {
        None = 0,

        [Alias("show-rex-bits")]
        ShowRexBits,

        [Alias("distill-statements")]
        DistillAsmStatements,

        ExportStokeImports,

        [Alias("emit-api-classes")]
        EmitApiClasses,

        EmitSymbolicLiterals,

        ShowAsmCatForms,

        EmitAsmCatForms,

        ShowEncodingKindNames,

        [Alias("correlate-api")]
        CorrelateApiCode,

        [Alias("emit-resbytes")]
        EmitResBytes,

        EmitImmSpecializations,

        CheckDigitParser,

        [Alias("emit-asm-rows")]
        EmitAsmRows,

        EmitLegacyOpCodes,
    }
}