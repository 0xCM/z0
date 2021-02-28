//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.IO;

    readonly struct AsmWriter : IAsmWriter
    {
        readonly StreamWriter StreamOut;

        readonly IAsmFormatter Formatter;

        public FS.FilePath TargetPath {get;}

        public AsmWriter(FS.FilePath path, IAsmFormatter formatter)
        {
            TargetPath = path;
            Formatter = formatter;
            StreamOut = path.Writer();
        }

        public void WriteAsm(params AsmRoutine[] src)
        {
            foreach(var f in src)
                StreamOut.Write(Formatter.Format(f));
        }

        public void Dispose()
        {
            StreamOut.Flush();
            StreamOut.Dispose();
        }
    }
}