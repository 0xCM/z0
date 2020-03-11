//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;

    readonly struct AsmHexWriter : IAsmHexWriter
    {        
        readonly StreamWriter StreamOut;

        public FilePath TargetPath {get;}

        public IAsmContext Context {get;}

        [MethodImpl(Inline)]
        public static IAsmHexWriter New(IAsmContext context, FilePath dst)
            => new AsmHexWriter(context, dst);

        [MethodImpl(Inline)]
        AsmHexWriter(IAsmContext context, FilePath path)
        {
            this.Context = context;
            this.TargetPath = path;
            this.StreamOut = new StreamWriter(path.CreateParentIfMissing().FullPath,false);
        }

        public void Write(in AsmOpBits src, int? uripad = null)
        {
            StreamOut.WriteLine(src.Format(uripad ?? 5));
        }

        public void Write(AsmOpBits[] src)
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
