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
            SourceRoot = shell.AppPaths.DevRoot + FolderName.Define("data") + FolderName.Define("sources") + FolderName.Define("xed");
            TargetRoot = shell.AppPaths.LogRoot + FolderName.Define("data") + FolderName.Define("xed");
        }

        public readonly WfSettings Settings;

        public readonly FolderPath SourceRoot;

        public readonly FolderPath TargetRoot;

        public FolderPath ExtractRoot
            => TargetRoot + FolderName.Define("extracts");

        public FolderPath PubRoot
            => TargetRoot + FolderName.Define("datasets");

        public FolderName ExtensionFolder
            => FolderName.Define("extensions");

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