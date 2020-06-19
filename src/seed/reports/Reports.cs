//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public static partial class Reports
    {
        [MethodImpl(Inline)]
        public static FieldFormatter<F> formatter<F>(char delimiter = FieldDelimiter)
            where F : unmanaged, Enum => Tabular.formatter<F>(delimiter);

        public static Option<FilePath> Save<F,R>(R[] src, FilePath dst)             
            where F : unmanaged, Enum 
            where R : ITabular
                => TableLog<F,R>.Service.Save(src,dst);

        public static IPublicationArchive Publications
            => PublicationArchive.Default;

    }

    public static partial class XTend    
    {

    }    
}
