//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct AsmOpCodes
    {
        [Op]
        public static AsmOpCodeDataset dataset()
        {
            var resource = ResExtractor.Service(typeof(Parts.Data).Assembly).MatchDocument("OpCodeSpecs");
            var count = resource.RowCount;
            var records = sys.alloc<AsmOpCodeRow>(count);
            AsmTables.parse(resource, records);
            var identifers = sys.alloc<AsmOpCodePattern>(count);
            AsmOpCodes.identify(records, identifers);
            return new AsmOpCodeDataset(records,identifers);
        }
    }
}