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
        public static IAsmCodeWriter New(IAsmContext context, FilePath dst)
            => new AsmCodeWriter(context, dst);

        [MethodImpl(Inline)]
        AsmCodeWriter(IAsmContext context, FilePath path)
        {
            this.Context = context;
            this.TargetPath = path;
            this.StreamOut = new StreamWriter(path.CreateParentIfMissing().FullPath,false);
        }

        public void WriteCode(in CapturedOp src, int? idpad = null)
            => StreamOut.WriteLine(src.Code.Format(idpad ?? 0));

        public void WriteCode(in AsmCode src, int? idpad = null)
        {
            StreamOut.WriteLine(src.Format(idpad ?? 0));
        }

        public void WriteHexLine(OpIdentity id, Span<byte> data, int? idpad = null)
            => StreamOut.WriteLine(HexLine.Define(id, data.ToArray()).Format(idpad ?? 0));

        public void WriteHexLine(in CapturedOp src, int? idpad = null)
            => WriteHexLine(src.Id, src.RawBits.Bytes, idpad);

        public void Write(AsmCode[] src)
        {
            var idpad = src.Max(x => x.Id.Identifier.Length) + 1;
            for(var i=0; i< src.Length; i++)
            {
                WriteCode(src[i], idpad);
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