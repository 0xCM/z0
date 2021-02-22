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

    public readonly struct ApiHexWriter : IApiHexWriter
    {
        /// <summary>
        /// The writer's target path
        /// </summary>
        public FS.FilePath TargetPath {get;}

        readonly StreamWriter StreamOut;

        [MethodImpl(Inline)]
        public ApiHexWriter(FS.FilePath path)
        {
            TargetPath = path;
            StreamOut = new StreamWriter(TargetPath.EnsureParentExists().Name,false);
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