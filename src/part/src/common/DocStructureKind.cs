//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using CK = DocContentKind;

    /// <summary>
    /// Defines classifiers for structured content
    /// </summary>
    public enum DocStructureKind : byte
    {
        None = 0,

        AsmIdentifiers = CK.AsmIdentifiers,

        AsmInstructions = CK.AsmInstructions,

        AsmSyntax = CK.AsmSyntax,

        AsmOpCodes = CK.AsmOpCodes,

        AsmBitFields = CK.AsmBitfields,
    }
}