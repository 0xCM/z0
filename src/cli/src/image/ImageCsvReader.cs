//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Images
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;
    using static corefunc;

    public ref struct ImageCsvReader
    {
        public static ImageCsvReader create(IWfShell wf, FS.FilePath src)
        {
            if(!src.Exists)
                corefunc.@throw(FS.missing(src));

            return new ImageCsvReader(wf, src);
        }

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
                corefunc.@throw(new FileNotFoundException(src.ToUri().Format()));
            Reader = src.Reader();
            FileSize = src.Size;
            Header = Reader.ReadLine();
            ByteParser = HexByteParser.Service;
        }

        public bool Read(ref ImageContentRecord data)
        {
            var line = Reader.ReadLine();
            if(line == null)
                return false;

            CurrentIndex++;

            var parts = text.split(line, FieldDelimiter);
            if(parts.Length != 2)
                return false;

            data.Address = succeed(HexNumericParser.parse(parts[0]));
            data.Data = succeed(ByteParser.ParseData(parts[1]));

            return true;
        }

        public void Dispose()
        {
            Reader?.Dispose();
        }
    }
}