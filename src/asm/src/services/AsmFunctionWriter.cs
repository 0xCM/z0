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

    readonly struct AsmFunctionWriter : IAsmFunctionWriter
    {        
        readonly StreamWriter StreamOut;

        readonly IAsmFormatter Formatter;

        public FilePath TargetPath {get;}
        
        public static AsmWriterFactory Factory
            => (dst,formatter) => new AsmFunctionWriter(dst,formatter);

        [MethodImpl(Inline)]
        public static IAsmFunctionWriter Create(FilePath dst, IAsmFormatter formatter)
            => new AsmFunctionWriter(dst, formatter);

        [MethodImpl(Inline)]
        AsmFunctionWriter(FilePath path, IAsmFormatter formatter)
        {
            this.TargetPath = path;
            this.Formatter = formatter;
            this.StreamOut = new StreamWriter(path.CreateParentIfMissing().FullPath,false);
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