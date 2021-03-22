//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public sealed class AsmCatalog : WfService<AsmCatalog>
    {
        public Index<XedSummaryRow> XedSummaries()
            => Xed.summaries(Db.TableArchive("xed"));
    }
}