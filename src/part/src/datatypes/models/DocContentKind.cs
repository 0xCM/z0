//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using CK = DocContentKind;

    public enum ContentLibField : ushort
    {
        Name = 80,

        Type = 20,
    }
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

    /// <summary>
    /// Defines resource content categories
    /// </summary>
    public enum DocContentKind : byte
    {
        None = 0,

        AsmAlgorithms,

        AsmIdentifiers,

        AsmInstructions,

        AsmSyntax,

        AsmOpCodes,

        AsmBitfields,

        Env,

        Help,

        PeFormat,

        ResX,

        Tools,

        Xed,

        Xml
    }
}