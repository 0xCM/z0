//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct AsmOpCodesLegacy
    {
        [Op]
        public static AsmOpCodeDatasetLegacy dataset()
        {
            var resource = ResExtractor.Service(typeof(Parts.Res).Assembly).MatchDocument(ContentNames.OpCodeSpecs);
            var count = resource.RowCount;
            var records = sys.alloc<AsmOpCodeRowLegacy>(count);
            parse(resource, records);
            var identifers = sys.alloc<AsmOpCodeExprLegacy>(count);
            AsmOpCodesLegacy.identify(records, identifers);
            return new AsmOpCodeDatasetLegacy(records,identifers);
        }
    }
}