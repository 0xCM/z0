//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Col0 = (Symbol | Identifier), Col1 = (Symbol | Description), Col3 = Description
    /// </summary>
    public class SymGen : CodeGenerator
    {
        public Outcome Generate(uint offset, in SymSeqSpec src, ITextBuffer dst)
        {

            var outcome = Outcome.Success;
            return outcome;
        }
    }
}