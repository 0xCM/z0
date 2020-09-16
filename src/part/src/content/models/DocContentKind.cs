//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

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