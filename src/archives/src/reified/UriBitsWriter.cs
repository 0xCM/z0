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

    public readonly struct UriBitsWriter : IUriBitsWriter
    {        
        readonly StreamWriter StreamOut;

        public FilePath TargetPath {get;}

        [MethodImpl(Inline)]
        internal UriBitsWriter(FilePath path)
        {
            this.TargetPath = path;
            this.StreamOut = new StreamWriter(path.CreateParentIfMissing().FullPath,false);
        }

        public void Write(in UriBits src, int? uripad = null)
        {
            StreamOut.WriteLine(src.Format(uripad ?? 5));
        }

        public void Write(UriBits[] src)
        {
            var uripad = src.Max(x => x.Op.Identifier.Length) + 1;
            for(var i=0; i< src.Length; i++)
            {
                Write(src[i], uripad);
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