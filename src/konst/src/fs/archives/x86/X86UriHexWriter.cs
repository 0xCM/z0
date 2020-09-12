//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct X86UriHexWriter : IX86UriHexWriter<X86UriHexWriter>
    {
        /// <summary>
        /// The writer's target path
        /// </summary>
        public FilePath TargetPath {get;}

        readonly StreamWriter StreamOut;

        [MethodImpl(Inline)]
        public X86UriHexWriter(FilePath path)
        {
            TargetPath = path;
            StreamOut = new StreamWriter(path.CreateParentIfMissing().FullPath,false);
        }

        public void Write(X86ApiCode src, int idpad = 60)
            => StreamOut.WriteLine(src.Format(idpad));

        public void Write(X86UriHex src, int idpad = 60)
            => StreamOut.WriteLine(src.Format(idpad));

        public void Dispose()
        {
            StreamOut.Flush();
            StreamOut.Dispose();
        }

    }
}