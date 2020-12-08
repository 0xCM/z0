//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.IO;

    using static Konst;
    using static z;

    public ref struct ImageCsvReader
    {
        readonly FS.FilePath Source;

        readonly StreamReader Reader;

        int Index;

        public string Header {get;}

        public ByteSize FileSize {get;}

        public ImageCsvReader(FS.FilePath src)
        {
            Source = src;
            Index = 0;
            if(!src.Exists)
                @throw(new FileNotFoundException(src.ToUri().Format()));

            Reader = src.Reader();
            FileSize = src.Size;
            Header = Reader.ReadLine();
        }




        public void Dispose()
        {

        }
    }
}