//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;

    struct ImageCsvReader : IImageReader
    {
        readonly FS.FilePath Source;

        readonly IWfShell Wf;

        readonly StreamReader Reader;

        uint CurrentIndex;

        public string Header {get;}

        public ByteSize FileSize {get;}

        public HexByteParser ByteParser;

        public ImageCsvReader(IWfShell wf, FS.FilePath src)
        {
            Wf = wf;
            Source = src;
            CurrentIndex = 0;
            if(!src.Exists)
                @throw(new FileNotFoundException(src.ToUri().Format()));
            Reader = src.Reader();
            FileSize = src.Size;
            Header = Reader.ReadLine();
            ByteParser = HexByteParser.Service;
        }

        public bool Read(ref ImageContent data)
        {
            var line = Reader.ReadLine();
            if(line == null)
                return false;

            CurrentIndex++;

            var parts = text.split(line, FieldDelimiter);
            if(parts.Length != 2)
                return false;

            data.Address = root.succeed(HexNumericParser.parse64u(parts[0]));
            data.Data = root.succeed(ByteParser.ParseData(parts[1]));

            return true;
        }

        public void Dispose()
        {
            Reader?.Dispose();
        }
    }
}