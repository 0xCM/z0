//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Part;
    using static memory;

    public class AsmStore : WfService<AsmStore,AsmStore>
    {
        ITableArchive XedArchive;

        Index<XedPatternRow> Summaries;

        protected override void OnInit()
        {
            XedArchive = Db.TableArchive("xed");
            Summaries = Xed.patterns(XedArchive);
        }

        public ReadOnlySpan<XedPatternRow> Patterns()
            => Summaries.View;
    }
}