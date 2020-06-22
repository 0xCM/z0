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

    public readonly struct UriHexWriter : IUriHexWriter
    {        
        readonly StreamWriter StreamOut;

        public FilePath TargetPath {get;}

        [MethodImpl(Inline)]
        public UriHexWriter(FilePath path)
        {
            this.TargetPath = path;
            this.StreamOut = new StreamWriter(path.CreateParentIfMissing().FullPath,false);
        }

        [MethodImpl(Inline)]
        public void Write(IdentifiedCode src, int idpad)
            => StreamOut.WriteLine(src.Format(idpad));

        [MethodImpl(Inline)]
        public void Write(IdentifiedCode src)
            => StreamOut.WriteLine(src.Format(0));

        public void Write(IdentifiedCode[] src)
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

        public static IdentifiedCode[] save(ApiHostUri host, ParsedExtract[] src, FilePath dst)
        {
            using var writer = new UriHexWriter(dst);
            var data = src.Map(x => new IdentifiedCode(x.OpUri, x.Encoded.Encoded));
            writer.Write(data);
            return data;
        }                
    }
}