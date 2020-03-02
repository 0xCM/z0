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

    readonly struct AsmRawWriter : IAsmRawWriter
    {        
        public IAsmContext Context {get;}

        readonly StreamWriter StreamOut;

        public FilePath TargetPath {get;}

        [MethodImpl(Inline)]
        public static IAsmRawWriter Create(IAsmContext context, FilePath dst)
            => new AsmRawWriter(context, dst);

        [MethodImpl(Inline)]
        AsmRawWriter(IAsmContext context, FilePath path)
        {
            this.Context = context;
            this.TargetPath = path;
            this.StreamOut = new StreamWriter(path.CreateParentIfMissing().FullPath,false);
        }

        public void Write(OpIdentity id, Span<byte> data, int? idpad = null)
            => StreamOut.WriteLine(HexLine.Define(id, data.ToArray()).Format(idpad ?? 0));

        public void Write(in AsmOpExtract src, int? idpad = null)
            => Write(src.Id, src.RawBits.Bytes, idpad);
        
        public void Dispose()
        {
            StreamOut.Flush();
            StreamOut.Dispose();
        }
    }
}