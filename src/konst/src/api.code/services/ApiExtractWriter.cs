//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ApiExtractWriter : IApiExtractWriter
    {
        /// <summary>
        /// The writer's target path
        /// </summary>
        public FS.FilePath TargetPath {get;}

        readonly StreamWriter StreamOut;

        [MethodImpl(Inline)]
        public ApiExtractWriter(FS.FilePath path)
        {
            TargetPath = path;
            StreamOut = new StreamWriter(TargetPath.EnsureParentExists().Name,false);
        }

        public void Write(ApiExtractBlock src, int idpad = 60)
            => StreamOut.WriteLine(src.Format(idpad));

        public void Dispose()
        {
            StreamOut.Flush();
            StreamOut.Dispose();
        }
    }
}