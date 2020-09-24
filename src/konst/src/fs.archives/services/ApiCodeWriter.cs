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

    public readonly struct ApiCodeWriter : IApiCodeWriter<ApiCodeWriter>
    {
        /// <summary>
        /// The writer's target path
        /// </summary>
        public FilePath TargetPath {get;}

        readonly StreamWriter StreamOut;

        [MethodImpl(Inline)]
        public ApiCodeWriter(FilePath path)
        {
            TargetPath = path;
            StreamOut = new StreamWriter(TargetPath.CreateParentIfMissing().FullPath,false);
        }

        [MethodImpl(Inline)]
        public ApiCodeWriter(FS.FilePath path)
        {
            TargetPath = FilePath.Define(path.Name);
            StreamOut = new StreamWriter(TargetPath.CreateParentIfMissing().FullPath,false);
        }

        public void Write(ApiCodeBlock src, int idpad = 60)
            => StreamOut.WriteLine(src.Format(idpad));

        public void Dispose()
        {
            StreamOut.Flush();
            StreamOut.Dispose();
        }

    }
}