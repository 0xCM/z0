//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    using static ImageSectionHeader;

    partial struct RecordApi
    {
        [Op]
        public static void format(in ImageSectionHeader src, DatasetFormatter<Fields> dst)
        {
            dst.Delimit(Fields.FileName, src.File);
            dst.Delimit(Fields.Section, src.SectionName);
            dst.Delimit(Fields.Address, src.RawData);
            dst.Delimit(Fields.Size, src.RawDataSize);
            dst.Delimit(Fields.EntryPoint, src.EntryPoint);
            dst.Delimit(Fields.CodeBase, src.CodeBase);
            dst.Delimit(Fields.Gpt, src.GptRva);
            dst.Delimit(Fields.GptSize, src.GptSize);
        }
    }
}