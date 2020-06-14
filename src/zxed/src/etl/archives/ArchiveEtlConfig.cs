//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using xed_ext = Z0.Xed.xed_extension_enum_t;
    using xed_cat = Z0.Xed.xed_category_enum_t;

    readonly struct AsmArchiveConfig
    {
        public FolderName RootFolder 
            => FolderName.Define("data");


        public FolderName StageFolder 
            => FolderName.Define("extracts");

        public FolderName DatasetFolder 
            => FolderName.Define("datasets");

        public FolderName ExtensionFolder 
            => FolderName.Define("extensions");

        public FolderName CategoryFolder 
            => FolderName.Define("categories");

        public FileExtension DataFileExt 
            => FileExtensions.Csv;

        public xed_ext[] Extensions => new xed_ext[]{
            xed_ext.XED_EXTENSION_BASE,             
            xed_ext.XED_EXTENSION_AVX, 
            xed_ext.XED_EXTENSION_AVX2,            
            xed_ext.XED_EXTENSION_BMI1,            
            xed_ext.XED_EXTENSION_BMI2,            
            xed_ext.XED_EXTENSION_SSE,            
            xed_ext.XED_EXTENSION_SSE2,            
        };

        public xed_cat[] Categories => new xed_cat[]{
            xed_cat.XED_CATEGORY_BINARY,
            xed_cat.XED_CATEGORY_SHIFT,
            xed_cat.XED_CATEGORY_BITBYTE,
            xed_cat.XED_CATEGORY_COND_BR,
            xed_cat.XED_CATEGORY_UNCOND_BR,
            xed_cat.XED_CATEGORY_LOGICAL,
        };
    }
}