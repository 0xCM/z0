//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Table
    {
        [MethodImpl(Inline), Op]
        public static TableArchive archive(FolderPath root)
            => new TableArchive(root);

        [MethodImpl(Inline), Op]
        public static FilePath path(FolderPath dst, IDataModel model)
            => dst + FileName.Define(model.Name, FileExtensions.Csv);
    }
}