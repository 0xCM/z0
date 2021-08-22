//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;
    using static core;
    using static SdmModels;

    partial class AsmCmdService
    {
        public Outcome ImportSdmTables()
        {
            var result = Outcome.Success;
            var src = DataSources.Datasets(AsmTableScopes.SdmInstructions).Files(FS.Csv).ToReadOnlySpan();
            var records = SdmSvc.ImportCsvOpCodes(src);
            return result;
        }

        Outcome DeriveSdmOpCodeStrings()
        {
            var result = Outcome.Success;

            result = LoadSdmOpCodeDetails(out var opcodes);
            if(result.Fail)
                return result;

            var count = opcodes.Length;
            var items = alloc<ListItem<string>>(count);
            for(var i=0u; i<count; i++)
                seek(items,i) = (i,skip(opcodes,i).OpCode);

            var dst = Wf.EnvPaths.Codebase(PartId.AsmData) + FS.folder("src/sources/gen");
            var spec = StringTables.specify("Z0.Asm", "OpCodeStrings", items);
            return Wf.Generators().Generate(spec,dst);
        }

        Outcome SdmImport()
        {
            var result = ImportSdmTables();
            if(result.Fail)
                return result;

            SdmSvc.DeriveAsmForms(TableWs().Table<SdmOpCodeDetail>());

            result = DeriveSdmOpCodeStrings();
            return result;
        }

        Outcome LoadSdmOpCodeDetails(out SdmOpCodeDetail[] dst)
        {
            var result = Outcome.Success;
            var srcpath = TableWs().Table<SdmOpCodeDetail>();
            result = SdmSvc.LoadImportedOpCodes(srcpath, out dst);
            if(result.Fail)
                return result;
            State.SdmOpCodeDetail(dst);
            return result;
        }
    }
}