//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    partial struct AsmOpCodes
    {
         [Op]
        public static AsmOpCodeDataset dataset()
        {
            var resource = ResExtractor.Service(typeof(Parts.Res).Assembly).MatchDocument(ContentNames.OpCodeSpecs);
            var count = resource.RowCount;
            var records = sys.alloc<AsmOpCodeRow>(count);
            parse(resource, records);
            var identifers = sys.alloc<AsmOpCode>(count);
            AsmOpCodes.identify(records, identifers);
            return new AsmOpCodeDataset(records,identifers);
        }
    }
}