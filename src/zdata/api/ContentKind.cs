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
    public enum ContentKind : byte
    {
        None = 0,

        AsmAlg,

        AsmId,

        AsmInxs,

        AsmSyn,

        AsmT,

        Env,

        Help,

        PeFormat,

        ResX,

        Tools,
        
        Xed,

        Xml
    }
}