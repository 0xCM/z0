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

    using static Seed;

    public readonly struct BitArchiveWriter : IBitArchiveWriter
    {        
        readonly StreamWriter StreamOut;

        public FilePath TargetPath {get;}

        [MethodImpl(Inline)]
        internal BitArchiveWriter(FilePath path)
        {
            this.TargetPath = path;
            this.StreamOut = new StreamWriter(path.CreateParentIfMissing().FullPath,false);
        }

        public void WriteHex(in OperationBits src, int? idpad = null)
        {
            StreamOut.WriteLine(src.Format(idpad ?? 0));
        }
        
        public void WriteHex(in EncodedHexLine src, int? idpad = null)
        {
            StreamOut.WriteLine(src.Format(idpad ?? 0));
        }

        public void WriteHex(OperationBits[] src)
        {
            var idpad = src.Max(x => x.Uri.Identifier.Length) + 1;
            for(var i=0; i< src.Length; i++)
            {
                WriteHex(src[i], idpad);
            }
        
            StreamOut.Flush();
        }
        public void Dispose()
        {
            StreamOut.Flush();
            StreamOut.Dispose();
        }
    }
}