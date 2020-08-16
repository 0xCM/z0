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

    public readonly struct AsmFunctionWriter : IAsmFunctionWriter
    {        
        readonly StreamWriter StreamOut;

        readonly IAsmFormatter Formatter;

        public FilePath TargetPath {get;}
        
        public static AsmWriterFactory Factory
            => (dst,formatter) => new AsmFunctionWriter(dst,formatter);

        [MethodImpl(Inline)]
        public static AsmFunctionWriter Create(FilePath dst, IAsmFormatter formatter)
            => new AsmFunctionWriter(dst, formatter);

        [MethodImpl(Inline)]
        public AsmFunctionWriter(FilePath path, IAsmFormatter formatter)
        {
            TargetPath = path;
            Formatter = formatter;
            StreamOut = new StreamWriter(path.CreateParentIfMissing().FullPath,false);
        }
    
        public void WriteAsm(params AsmFunction[] src)
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