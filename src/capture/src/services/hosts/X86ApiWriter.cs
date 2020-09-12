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

    public readonly struct X86ApiWriter : IDisposable
    {
        readonly StreamWriter StreamOut;

        public FilePath TargetPath {get;}

        readonly FS.FilePath Target;

        [MethodImpl(Inline)]
        public X86ApiWriter(FS.FilePath dst)
        {
            TargetPath = FilePath.Define(dst.Name);
            Target  = dst;
            StreamOut = new StreamWriter(dst.CreateParentIfMissing().Name, false);
        }

        public void Write(in X86UriHex src, int idpad)
            => StreamOut.WriteLine(src.Format(idpad));

        public void WriterLine(in X86UriHex src)
            => StreamOut.WriteLine(src.Format(0));

        public void WriteLines(X86UriHex[] src)
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


        public static X86UriHex[] save(ApiHostUri host, X86ApiMembers src, FS.FilePath dst)
        {
            using var writer = new X86ApiWriter(dst);
            var data = src.Storage.Map(x => new X86UriHex(x.Address, x.OpUri, x.Encoded.Encoded));
            writer.WriteLines(data);
            return data;
        }

        public void Write(in X86UriHex code)
            => Write(code,60);
    }
}