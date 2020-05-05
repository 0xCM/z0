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

    public readonly struct UriCodeWriter : IUriCodeWriter
    {        
        /// <summary>
        /// The writer's target path
        /// </summary>
        public FilePath TargetPath {get;}

        readonly StreamWriter StreamOut;

        [MethodImpl(Inline)]
        internal UriCodeWriter(FilePath path)
        {
            this.TargetPath = path;
            this.StreamOut = new StreamWriter(path.CreateParentIfMissing().FullPath,false);
        }

        [MethodImpl(Inline)]
        public void Write(UriCode src, int idpad)
            => StreamOut.WriteLine(src.Format(idpad));

        [MethodImpl(Inline)]
        public void Write(UriCode src)
            => Write(src,0);

        public void Write(UriCode[] src)
        {
            var idpad = src.Max(x => x.Uri.IdentityText.Length) + 1;
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