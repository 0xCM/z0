//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;

    using xed_ext = xed_extension_enum_t;
    using xed_cat = xed_category_enum_t;

    public readonly struct XedEtlConfig
    {
        public XedEtlConfig(IWfShell shell, WfSettings settings)
        {
            Settings = settings;
            SourceRoot = FS.dir(shell.Paths.DevRoot.Name) + FS.folder("data") + FS.folder("sources") + FS.folder("xed");
            TargetRoot = FS.dir(shell.Paths.LogRoot.Name) + FS.folder("data") + FS.folder("xed");
        }

        public readonly WfSettings Settings;

        public readonly FS.FolderPath SourceRoot;

        public readonly FS.FolderPath TargetRoot;

        public FS.FolderPath ExtractRoot
            => TargetRoot + FS.folder("extracts");

        public FS.FolderPath PubRoot
            => TargetRoot + FS.folder("datasets");

        public FS.FolderName ExtensionFolder
            => FS.folder("extensions");

        public FolderName CategoryFolder
            => FolderName.Define("categories");

        public FileExtension DataFileExt
            => FileExtensions.Csv;

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