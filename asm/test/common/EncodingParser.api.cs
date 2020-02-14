//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    
    using static zfunc;

    public static class EncodingParser
    {
        public static ByteParser<EncodingPatternKind> Create(int size)
            => ByteParser<EncodingPatternKind>.Create(size, new EncodingPatterns(0));

        const int idPad = 50;

        const int maxbytes = Pow2.T14;

        const int statusPad = 16;

        const int codePad = 16;

        const int lengthPad = 8;

        const string sep = " | ";

        static void Capture(ApiHost host, FilePath dstpath)
        {
            
        }
        
        static void Capture0(ApiHost host, FilePath dstpath)
        {
            var methods = host.EncodedMethods().ToArray();

            var distinct = methods.Select(x => x.Id).ToSet();
            if(distinct.Count != methods.Length)
            {
                var index = new Dictionary<OpIdentity,int>();
                foreach(var m in methods)
                {
                    if(index.TryGetValue(m.Id, out var count ))
                        index[m.Id] = ++count;
                    else
                        index[m.Id] = 1;
                }
                var duplicates = string.Join(comma(), from kvp in index where kvp.Value > 1 select kvp.Key);
                print($"{host} method identifier duplicates: {duplicates}",SeverityLevel.Warning);
            }

            Span<byte> buffer = new byte[maxbytes];

            var reader = ByteReader.Create();

            using var dst = dstpath.Writer();            

            for(var i=0; i<methods.Length; i++)
            {
                var current = methods[i];
                var id = current.Id.ToString().PadRight(idPad);
                var location = current.Location;

                buffer.Clear();
                var rawcount = reader.Read(location, maxbytes, buffer);                
                var raw = buffer.Slice(0,rawcount);
                var hexline = concat(id, space(), raw.FormatHex());                
                dst.WriteLine(hexline); 
            }
        }

        static void Parse(HexLine src, ByteParser<EncodingPatternKind> parser, StreamWriter dst)
        {
            (var id, var data) = src;

            var status = parser.Parse(data);
            var contented = parser.Result.IsSome() && status.Success();
            var datafmt = contented ? parser.Parsed.FormatHex() : string.Empty;                
            var length = contented ? parser.Parsed.Length : 0;
            var csvline = string.Join(sep,
                id.ToString().PadRight(idPad),
                status.ToString().PadRight(statusPad), 
                parser.Result.ToString().PadRight(codePad),            
                length.ToString().PadRight(lengthPad),        
                datafmt);
            dst.WriteLine(csvline); 

        }

        static void Parse(FilePath srcpath, FilePath dstpath)
        {
            var parser = EncodingParser.Create(maxbytes);

            using var src = srcpath.Reader();
            using var dst = dstpath.Writer();

            var header = string.Join(sep, 
                "OpId".PadRight(idPad), 
                "Status".PadRight(statusPad), 
                "Code".PadRight(codePad),
                "Length".PadRight(lengthPad),
                "Parsed"
                );
            dst.WriteLine(header);
            
            var txtLine = src.ReadLine();
            while(txtLine != null)
            {
                Parse(HexLine.Parse(txtLine).Require(),parser,dst);                
                txtLine = src.ReadLine();
            }
        }

        public static void Parse(ApiHost host)
        {
            print($"Emitting {host.Path} method encodings");            
            
            var hexpath = AsmReports.HostLocation(host).WithExtension(FileExtensions.Hex);
            var csvpath = hexpath.WithExtension(FileExtensions.Csv);
            
            Capture0(host, hexpath);            
            Parse(hexpath, csvpath);
        }
    }
}