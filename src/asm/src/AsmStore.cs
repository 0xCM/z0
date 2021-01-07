//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Part;

    public class AsmStore : WfService<AsmStore,AsmStore>
    {
        ITableArchive Tables;

        Index<XedSummaryRow> Rows;

        protected override void OnInit()
        {
            Tables = Db.TableArchive("xed");
            Rows = Xed.summaries(Tables);
        }

        public ReadOnlySpan<XedSummaryRow> Summaries()
            => Rows.View;
    }
}