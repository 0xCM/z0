//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmWriter : IAsmWriter
    {
        readonly StreamWriter StreamOut;

        readonly IAsmFormatter Formatter;

        public FS.FilePath TargetPath {get;}

        public static AsmTextWriterFactory Factory
            => (dst,formatter) => new AsmWriter(dst,formatter);

        [MethodImpl(Inline)]
        public AsmWriter(FilePath path, IAsmFormatter formatter)
        {
            TargetPath = FS.path(path.Name);
            Formatter = formatter;
            StreamOut = new StreamWriter(path.CreateParentIfMissing().FullPath,false);
        }

        [MethodImpl(Inline)]
        public AsmWriter(FS.FilePath path, IAsmFormatter formatter)
        {
            TargetPath = path;
            Formatter = formatter;
            StreamOut = path.Writer();
        }

        public void WriteAsm(params AsmRoutine[] src)
        {
            foreach(var f in src)
                StreamOut.Write(Formatter.FormatFunction(f));
        }

        public void Dispose()
        {
            StreamOut.Flush();
            StreamOut.Dispose();
        }
    }
}