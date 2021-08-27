//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using static LlvmDataSourceNames;
    using static LlvmDatasetNames;
    using static WsAtoms;

    using K = LlvmDatasetKind;

    public class LlvmPaths : WsService<LlvmPaths>
    {
        public FS.FilePath LinedRecordPath(LlvmDatasetKind kind)
            => Ws.Tables().Subdir(llvm) + lined(kind);

        public FS.FilePath DataSourcePath(LlvmDatasetKind kind)
            => path(Ws.Sources(), kind);

        public FS.FolderPath LlvmTables()
            => Ws.Tables().Subdir(llvm);

        public FS.FilePath RecordIndex(string id)
            => LlvmTables() + FS.file(string.Format("{0}.index", id), FS.Csv);

        public FS.FilePath LineMapPath(string id)
            => LlvmTables() + FS.file(id,FS.ext("map"));

        public FS.FilePath OpCodeTable()
            => Ws.Tables().LlvmTable<OpCodeSpec>();

        static FS.FileName lined(LlvmDatasetKind kind)
            => kind switch
            {
                K.Instructions => FS.file(X86Instructions,FS.Txt),
                K.Intrinsics => FS.file(LlvmIntrinsics,FS.Txt),
                _ => FS.FileName.Empty,
            };

        static FS.FilePath path(IWorkspace sources, LlvmDatasetKind kind)
        {
            var file = FS.FileName.Empty;
            switch(kind)
            {
                case LlvmDatasetKind.Intrinsics:
                        file = FS.file(InstrinsicsSummary, FS.Txt);
                break;
                case LlvmDatasetKind.Instructions:
                        file = FS.file(X86Summary, FS.Txt);
                break;
                case LlvmDatasetKind.ValueTypes:
                        file = FS.file(ValueTypesSummary, FS.Txt);
                break;
            }

            return file.IsNonEmpty ? sources.Datasets(TblgenRecords) + file : FS.FilePath.Empty;
        }
    }
}
