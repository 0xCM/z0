//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    //[WfCmdKind]
    public enum AsmWfCmdKind : byte
    {
        None = 0,

        [Alias("distill-statements")]
        DistillAsmStatements,

        ExportStokeImports,

        [Alias("emit-api-classes")]
        EmitApiClasses,

        EmitSymbolicLiterals,

        [Alias("show-forms")]
        ShowStandfordForms,

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