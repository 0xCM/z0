//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using CK = ContentKind;

    /// <summary>
    /// Defines classifiers for structured content
    /// </summary>
    public enum StructuredKind : byte
    {
        None = 0,

        AsmId = CK.AsmId,

        AsmInxs = CK.AsmInxs,

        AsmSyn = CK.AsmSyn,

        AsmT = CK.AsmT,

        Env = CK.Env,        

        Help = CK.Help,

        PeFormat = CK.PeFormat,
    }
}