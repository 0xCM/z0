//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct XedWfConfig
    {
        public XedWfConfig(IWfShell wf)
        {
            Settings = XedSettings.Default();
            var db = wf.Db();

            Source = db.DevData("xed");
            Target = db.TableRoot("xed");
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

        public FS.FolderName FunctionFolder
            => FS.folder("functions");

        public FS.FolderName InstructionFolder
            => FS.folder("instructions");

        public FS.FolderName RuleFolder
            => FS.folder("rules");

        public FS.FolderPath InstructionDir
            => Target + InstructionFolder;

        public FS.FolderPath FunctionDir
            => Target + FunctionFolder;

        public FS.FileExt DataFileExt
            => FileExtensions.Csv;

        public XedExtension[] Extensions
        {
            [Op]
            get => ExtensionData;
        }

        public XedCategory[] Categories
        {
            [Op]
            get => CategoryData;
        }

       static XedExtension[] ExtensionData => new XedExtension[]{
            XedExtension.XED_EXTENSION_BASE,
            XedExtension.XED_EXTENSION_AVX,
            XedExtension.XED_EXTENSION_AVX2,
            XedExtension.XED_EXTENSION_BMI1,
            XedExtension.XED_EXTENSION_BMI2,
            XedExtension.XED_EXTENSION_SSE,
            XedExtension.XED_EXTENSION_SSE2,
        };

       static XedCategory[] CategoryData => new XedCategory[]{
            XedCategory.XED_CATEGORY_BINARY,
            XedCategory.XED_CATEGORY_SHIFT,
            XedCategory.XED_CATEGORY_BITBYTE,
            XedCategory.XED_CATEGORY_COND_BR,
            XedCategory.XED_CATEGORY_UNCOND_BR,
            XedCategory.XED_CATEGORY_LOGICAL,
        };
    }
}