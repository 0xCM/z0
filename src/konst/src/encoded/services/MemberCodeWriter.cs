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

    public readonly struct MemberCodeWriter : IMemberCodeWriter
    {        
        /// <summary>
        /// The writer's target path
        /// </summary>
        public FilePath TargetPath {get;}

        readonly StreamWriter StreamOut;

        [MethodImpl(Inline)]
        public MemberCodeWriter(FilePath path)
        {
            TargetPath = path;
            StreamOut = new StreamWriter(path.CreateParentIfMissing().FullPath,false);
        }

        [MethodImpl(Inline)]
        public void Write(MemberCode src, int idpad = 60)
            => StreamOut.WriteLine(src.Format(idpad));

        [MethodImpl(Inline)]
        public void WriterLine(MemberCode src)
            => Write(src,0);

        public void WriteLines(MemberCode[] src)
        {
            var idpad = src.Max(x => x.OpUri.UriText.Length) + 1;
            for(var i=0; i< src.Length; i++)
                Write(src[i], idpad);                        
            StreamOut.Flush();
        }
 
        public void Dispose()
        {
            StreamOut.Flush();
            StreamOut.Dispose();
        }
    }
}