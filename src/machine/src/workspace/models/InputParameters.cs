//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public class InputParameters : PromptSyntaxList<InputParameters, PromptInputSyntax>
    {
        public InputParameters()
            : base(" ")
        { }
    }
}