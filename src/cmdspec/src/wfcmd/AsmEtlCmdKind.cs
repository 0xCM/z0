//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [WfCmdKind]
    public enum AsmEtlCmdKind : byte
    {
        None,

        [Alias("emit-form-catalog")]
        EmitFormCatalog,
    }
}
