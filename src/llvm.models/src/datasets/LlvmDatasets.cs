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

    public class LlvmDatasets : WsService<LlvmDatasets>
    {
        public FS.FilePath Lined(LlvmDatasetKind kind)
            => Ws.Tables().Subdir(llvm) + lined(kind);

        public Outcome<FS.FilePath> Load(LlvmDatasetKind kind, ref LlvmRecordSources dst)
        {
            return load(Ws.Sources(), kind,ref dst);
        }

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

        static Outcome<FS.FilePath> load(IWorkspace sources, LlvmDatasetKind kind, ref LlvmRecordSources dst)
        {
            var path = FS.FilePath.Empty;
            switch(kind)
            {
                case LlvmDatasetKind.Intrinsics:
                    {
                        path = LlvmDatasets.path(sources, kind);
                        using var reader = path.Utf8LineReader();
                        dst.Intrinsics = reader.ReadAll().ToArray();
                    }
                break;
                case LlvmDatasetKind.Instructions:
                    {
                        path = LlvmDatasets.path(sources, kind);
                        using var reader = path.Utf8LineReader();
                        dst.Instructions = reader.ReadAll().ToArray();
                    }
                break;
                case LlvmDatasetKind.ValueTypes:
                    {
                        path = LlvmDatasets.path(sources, kind);
                        using var reader = path.Utf8LineReader();
                        dst.ValueTypes = reader.ReadAll().ToArray();
                    }
                break;
            }

            return path.IsNonEmpty ? (true,path) : false;
        }
    }
}