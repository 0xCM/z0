//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public class AsmDataStore : WfService<AsmDataStore,AsmDataStore>
    {
        ITableArchive XedTables;

        protected override void OnInit()
        {
            XedTables = Db.TableArchive("xed");
        }

        public ReadOnlySpan<XedSummaryRow> XedSummaries()
            => Xed.summaries(XedTables);
    }
}