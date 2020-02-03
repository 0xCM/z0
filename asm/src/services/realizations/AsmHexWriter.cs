//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Collections.Generic;

    using Z0.AsmSpecs;

    using static zfunc;

    sealed class AsmHexWriter : StreamWriter, IAsmHexWriter
    {        
        public static IAsmHexWriter Create(IAsmContext context, FilePath dst, bool append)
            => new AsmHexWriter(context, dst,append);

        AsmHexWriter(IAsmContext context, FilePath path, bool append)
            : base(path.FullPath, append)
        {
            this.Context = context;
            this.TargetPath = path;
        }

        public FilePath TargetPath {get;}

        public IAsmContext Context {get;}

        byte[] Buffer {get; set;}
            = new byte[NativeServices.DefaultBufferLen];

        public void Write(AsmCode src, int? idpad = null)
            => WriteLine(src.Format(idpad ?? 0));

        public void Write(AsmCode[] src, int? idpad = null)
        {
            var pad = idpad ?? src.Select(code => code.Id.Identifier.Length).Max() + 1;
            foreach(var item in src)
                Write(item,pad);
        }

        public void Write(CapturedMember src, int? idpad = null)
            => WriteLine(src.Code.Format(idpad ?? 0));

        public void Write(CapturedMember[] src, int? idpad = null)
        {
            var members = src.ToArray();
            var pad =  idpad ?? members.Select(m => m.Code.Id.Identifier.Length).Max() + 1;
            foreach(var member in members)
                Write(member.Code, pad);
        }

    }
}
