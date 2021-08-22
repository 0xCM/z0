//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using Z0.Asm;

    using static LlvmDataSourceNames;
    using static LlvmDatasetNames;

    public class LlvmDatasets : Service<LlvmDatasets>
    {
        IWorkspace Ws;

        public LlvmDatasets WithSource(IWorkspace ws)
        {
            Ws = ws;
            return this;
        }

        public static FS.FilePath path(IWorkspace sources, LlvmDatasetKind kind)
        {
            var single = (LlvmDatasetKind)((uint)kind & 0xF);
            var detail = (byte)(bit)((kind & LlvmDatasetKind.Details) != 0);
            var summary = (byte)(bit)((kind & LlvmDatasetKind.Summary) != 0);
            var file = FS.FileName.Empty;
            switch(single)
            {
                case LlvmDatasetKind.Intrinsics:
                    switch(detail)
                    {
                        case 0:
                        file = FS.file(InstrinsicsSummary, FS.Txt);
                        break;
                        case 1:
                        file = FS.file(InstrinsicsDetails, FS.Txt);
                        break;
                    }
                break;
                case LlvmDatasetKind.Instructions:
                    switch(detail)
                    {
                        case 0:
                        file = FS.file(X86Summary, FS.Txt);
                        break;
                        case 1:
                        file = FS.file(X86Details, FS.Txt);
                        break;
                    }
                break;
                case LlvmDatasetKind.ValueTypes:
                    switch(detail)
                    {
                        case 0:
                        file = FS.file(ValueTypesSummary, FS.Txt);
                        break;
                        case 1:
                        file = FS.file(ValueTypesDetails, FS.Txt);
                        break;
                    }
                break;
            }

            return file.IsNonEmpty ? sources.Datasets(TblgenRecords) + file : FS.FilePath.Empty;
        }

        public Outcome<FS.FilePath> Load(LlvmDatasetKind kind, ref LlvmRecordSources dst)
        {
            return load(Ws,kind,ref dst);
        }

        public static Outcome<FS.FilePath> load(IWorkspace sources, LlvmDatasetKind kind, ref LlvmRecordSources dst)
        {
            var single = (LlvmDatasetKind)((uint)kind & 0xF);
            var detail = (byte)(bit)((kind & LlvmDatasetKind.Details) != 0);
            var summary = (byte)(bit)((kind & LlvmDatasetKind.Summary) != 0);
            var path = FS.FilePath.Empty;
            switch(single)
            {
                case LlvmDatasetKind.Intrinsics:
                    switch(detail)
                    {
                        case 1:
                            {
                                path = LlvmDatasets.path(sources, single | LlvmDatasetKind.Details);
                                using var reader = path.Utf8LineReader();
                                dst.IntrinsicsDetails = reader.ReadAll().ToArray();
                            }
                        break;

                    }
                    switch(summary)
                    {
                        case 1:
                            {
                                path = LlvmDatasets.path(sources, single | LlvmDatasetKind.Summary);
                                using var reader = path.Utf8LineReader();
                                dst.IntrinsicsSummary = reader.ReadAll().ToArray();
                            }
                        break;
                    }
                break;
                case LlvmDatasetKind.Instructions:
                    switch(detail)
                    {
                        case 1:
                            {
                                path = LlvmDatasets.path(sources, single | LlvmDatasetKind.Details);
                                using var reader = path.Utf8LineReader();
                                dst.InstructionDetails = reader.ReadAll().ToArray();
                            }
                        break;
                    }
                    switch(summary)
                    {
                        case 1:
                            {
                                path = LlvmDatasets.path(sources, single | LlvmDatasetKind.Summary);
                                using var reader = path.Utf8LineReader();
                                dst.InstructionSummary = reader.ReadAll().ToArray();
                            }
                        break;
                    }
                break;
                case LlvmDatasetKind.ValueTypes:
                    switch(detail)
                    {
                        case 1:
                            {
                                path = LlvmDatasets.path(sources, single | LlvmDatasetKind.Details);
                                using var reader = path.Utf8LineReader();
                                dst.ValueTypesDetails = reader.ReadAll().ToArray();
                            }
                        break;
                    }
                    switch(summary)
                    {
                        case 1:
                            {
                                path = LlvmDatasets.path(sources, single | LlvmDatasetKind.Summary);
                                using var reader = path.Utf8LineReader();
                                dst.ValueTypesSummary = reader.ReadAll().ToArray();
                            }
                        break;
                    }
                break;
            }

            return path.IsNonEmpty ? (true,path) : false;
        }
    }
}