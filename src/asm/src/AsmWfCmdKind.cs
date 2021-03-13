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

        [Alias("show-forms")]
        ShowFormCatalog,

        [Alias("emit-form-catalog")]
        EmitFormCatalog,

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