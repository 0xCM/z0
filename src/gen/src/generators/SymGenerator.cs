//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static core;


    /// <summary>
    /// Col0 = (Symbol | Identifier), Col1 = (Symbol | Description), Col3 = Description
    /// </summary>
    public class SymGen : CodeGenerator<SymSeqSpec>
    {
        public override Outcome Generate(in SymSeqSpec src, ITextBuffer dst)
        {

            var outcome = Outcome.Success;
            return outcome;
        }
    }

}
