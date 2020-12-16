//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using xed_ext = Xed.xed_extension_enum_t;
    using xed_cat = Xed.xed_category_enum_t;

    public readonly struct XedWfConfig
    {
        public XedWfConfig(IWfShell wf)
        {
            Settings = XedSettings.Default();
            var db = wf.Db();

            Source = db.DevData("xed");
            Target = db.RefData("xed");
        }

        public FS.FileName SummaryFile
            => FS.file(text.format("{0}.{1}", "xed", "summary"), DataFileExt);

        public XedSettings Settings {get;}

        public FS.FolderPath Source {get;}

        public FS.FolderPath Target {get;}

        public FS.FolderName ExtensionFolder
            => FS.folder("extensions");

        public FS.FolderName CategoryFolder
            => FS.folder("categories");

        public FS.FileExt DataFileExt
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