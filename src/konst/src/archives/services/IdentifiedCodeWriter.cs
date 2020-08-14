//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct IdentifiedCodeWriter : IIdentifiedCodeWriter
    {        
        readonly StreamWriter StreamOut;

        public FilePath TargetPath {get;}

        [MethodImpl(Inline)]
        public IdentifiedCodeWriter(FilePath path)
        {
            TargetPath = path;
            StreamOut = new StreamWriter(path.CreateParentIfMissing().FullPath,false);
        }

        public void Write(IdentifiedCode src, int idpad)
            => StreamOut.WriteLine(src.Format(idpad));

        public void WriterLine(IdentifiedCode src)
            => StreamOut.WriteLine(src.Format(0));

        public void WriteLines(IdentifiedCode[] src)
        {
            var uripad = src.Max(x => x.OpUri.UriText.Length) + 1;
            for(var i=0; i< src.Length; i++)
                Write(src[i], uripad);
            StreamOut.Flush();
        }        
        
        public void Dispose()
        {
            StreamOut.Flush();
            StreamOut.Dispose();
        }

        public static IdentifiedCode[] save(ApiHostUri host, ParsedExtraction[] src, FilePath dst)
        {
            using var writer = new IdentifiedCodeWriter(dst);
            var data = src.Map(x => new IdentifiedCode(x.Address, x.OpUri, x.Encoded.Encoded));
            writer.WriteLines(data);
            return data;
        }                
    }
}