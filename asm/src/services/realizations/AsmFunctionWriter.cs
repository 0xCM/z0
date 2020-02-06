//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using Z0.AsmSpecs;

    using static zfunc;

    sealed class AsmFunctionWriter : StreamWriter, IAsmFunctionWriter
    {        
        public static IAsmFunctionWriter Create(IAsmContext context, FilePath dst)
            => new AsmFunctionWriter(context, dst);
                    
        AsmFunctionWriter(IAsmContext context, FilePath path)
            : base(path.FullPath, false)
        {
            this.Context = context;
        }
    
        public IAsmContext Context {get;}

        byte[] Buffer {get; set;}
            = new byte[CaptureServices.DefaultBufferLen];

        public void Write(AsmFunction src)
        {
            Write(Context.AsmFormatter().FormatDetail(src));
        }

        public byte[] TakeBuffer()
        {
            Buffer.Clear();
            return Buffer;
        }

        public void Write(AsmFunctionGroup src) {}
    }
}