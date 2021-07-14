//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Root;
    using static core;

    public class ImageCsvReader : AppService<ImageCsvReader>
    {
        uint CurrentIndex;

        public HexByteParser ByteParser;

        public ImageCsvReader()
        {
            CurrentIndex = 0;
            ByteParser = HexByteParser.Service;
        }

        public FS.Files ImageContentFiles()
            => Db.TableDir<ImageContentRecord>().AllFiles;

        public ReadOnlySpan<ImageContentRecord> Load(FS.FilePath src)
        {
            var buffer = list<ImageContentRecord>();
            void Receive(in ImageContentRecord src)
            {
                buffer.Add(src);
            }

            Read(src, Receive);
            return buffer.ViewDeposited();
        }

        public void Read(FS.FilePath src, Receiver<ImageContentRecord> dst)
        {
            CurrentIndex = 0;

            if(!src.Exists)
                Root.@throw(new FileNotFoundException(src.ToUri().Format()));

            using var reader = src.Utf8Reader();
            var size = src.Size;
            var header = reader.ReadLine();
            var record = default(ImageContentRecord);
            var @continue = true;
            while(@continue)
            {
                if(Read(reader, ref record))
                    dst(record);
                else
                    @continue = false;
            }
        }

        public bool Read(StreamReader src, ref ImageContentRecord data)
        {
            var line = src.ReadLine();
            if(line == null)
                return false;

            CurrentIndex++;

            var parts = text.split(line, FieldDelimiter);
            if(parts.Length != 2)
                return false;

            DataParser.parse(skip(parts,0), out data.Address);
            DataParser.parse(skip(parts,1), out data.Data);

            return true;
        }
    }
}