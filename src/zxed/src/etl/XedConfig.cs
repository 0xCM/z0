//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using xed_ext = Xed.xed_extension_enum_t;
    using xed_cat = Xed.xed_category_enum_t;

    public readonly struct XedConfig
    {
        public XedConfig(IWfShell wf, WfSettings settings)
        {
            Settings = XedSettings.Default();
            SourceRoot = FS.dir(wf.Paths.DevRoot.Name) + FS.folder("data") + FS.folder("sources") + FS.folder("xed");
            TargetRoot = FS.dir(wf.Paths.LogRoot.Name) + FS.folder("data") + FS.folder("xed");
            Target = TableArchive.create(wf.FileDb().Root + FS.folder("tables") + FS.folder("xed"));
        }

        public readonly ITableArchive Target;

        public FS.FileName SummaryFile
            => FS.file(text.format("{0}.{1}", "xed", "summary"), DataFileExt);

        public readonly XedSettings Settings;

        public readonly FS.FolderPath SourceRoot;

        public readonly FS.FolderPath TargetRoot;

        public FS.FolderPath ExtractRoot
            => TargetRoot + FS.folder("extracts");

        public FS.FolderPath PubRoot
            => Target.Root;

        public FS.FolderName ExtensionFolder
            => FS.folder("extensions");

        public FS.FolderName CategoryFolder
            => FS.folder("categories");

        public FS.FileExt DataFileExt
            => ArchiveExt.Csv;

        public xed_ext[] Extensions
        {
            [Op]
            get => ExtensionData;
        }

        public xed_cat[] Categories
        {
            [Op]
            get => CategoryData;
        }

       static xed_ext[] ExtensionData => new xed_ext[]{
            xed_ext.XED_EXTENSION_BASE,
            xed_ext.XED_EXTENSION_AVX,
            xed_ext.XED_EXTENSION_AVX2,
            xed_ext.XED_EXTENSION_BMI1,
            xed_ext.XED_EXTENSION_BMI2,
            xed_ext.XED_EXTENSION_SSE,
            xed_ext.XED_EXTENSION_SSE2,
        };

       static xed_cat[] CategoryData => new xed_cat[]{
            xed_cat.XED_CATEGORY_BINARY,
            xed_cat.XED_CATEGORY_SHIFT,
            xed_cat.XED_CATEGORY_BITBYTE,
            xed_cat.XED_CATEGORY_COND_BR,
            xed_cat.XED_CATEGORY_UNCOND_BR,
            xed_cat.XED_CATEGORY_LOGICAL,
        };
    }
}