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

    using static zfunc;

    readonly struct AsmCodeWriter : IAsmCodeWriter
    {        
        readonly StreamWriter StreamOut;

        public FilePath TargetPath {get;}

        public IAsmContext Context {get;}

        [MethodImpl(Inline)]
        public static IAsmCodeWriter Create(IAsmContext context, FilePath dst, bool append)
            => new AsmCodeWriter(context, dst,append);

        [MethodImpl(Inline)]
        AsmCodeWriter(IAsmContext context, FilePath path, bool append)
        {
            this.Context = context;
            this.TargetPath = path;
            this.StreamOut = new StreamWriter(path.CreateParentIfMissing().FullPath,append);
        }

        public void Write(AsmCode src, int? idpad = null)
            => StreamOut.WriteLine(src.Format(idpad ?? 0));

        public void Write(AsmCode[] src, int? idpad = null)
        {
            var pad = idpad ?? src.Select(code => code.Id.Identifier.Length).Max() + 1;
            foreach(var item in src)
                Write(item,pad);
        }

        public void Dispose()
        {
            StreamOut.Flush();
            StreamOut.Dispose();
        }
    }
}
