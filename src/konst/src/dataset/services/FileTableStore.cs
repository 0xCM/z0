//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;

    public readonly struct FileTableStore
    {
        public FolderPath Root {get;}
        
        [MethodImpl(Inline)]
        public FileTableStore(FolderPath root)
        {
            Root = root;
        }


        public Option<FilePath> Deposit<F,R>(R[] src, FileName name)            
            where F : unmanaged, Enum
            where R : ITabular
                => Tabular.Store<F,R>().Save(src, Tabular.Specify<F>(), Root + name);

        public Option<FilePath> Deposit<F,R>(R[] src, FolderName folder, FileName name)
            where F : unmanaged, Enum
            where R : ITabular
                => Tabular.Store<F,R>().Save(src, Tabular.Specify<F>(), (Root + folder) + name);        
    }
}