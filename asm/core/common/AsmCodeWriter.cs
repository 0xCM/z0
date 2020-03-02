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

    using static Root;

    readonly struct AsmCodeWriter : IAsmCodeWriter
    {        
        readonly StreamWriter StreamOut;

        public FilePath TargetPath {get;}

        public IAsmContext Context {get;}

        [MethodImpl(Inline)]
        public static IAsmCodeWriter Create(IAsmContext context, FilePath dst)
            => new AsmCodeWriter(context, dst);

        [MethodImpl(Inline)]
        AsmCodeWriter(IAsmContext context, FilePath path)
        {
            this.Context = context;
            this.TargetPath = path;
            this.StreamOut = new StreamWriter(path.CreateParentIfMissing().FullPath,false);
        }

        public void Write(in AsmOpExtract src, int? idpad = null)
            => StreamOut.WriteLine(src.Code.Format(idpad ?? 0));
        public void Dispose()
        {
            StreamOut.Flush();
            StreamOut.Dispose();
        }
    }
}