//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Seed;

    readonly struct AsmFunctionWriter : IAsmFunctionWriter
    {        
        readonly StreamWriter StreamOut;

        readonly IAsmFormatter Formatter;

        readonly IContext Context;

        public FilePath TargetPath {get;}

        [MethodImpl(Inline)]
        public static IAsmFunctionWriter Create(IContext context, FilePath dst, IAsmFormatter formatter)
            => new AsmFunctionWriter(context, dst, formatter);

        [MethodImpl(Inline)]
        AsmFunctionWriter(IContext context, FilePath path, IAsmFormatter formatter)
        {
            this.TargetPath = path;
            this.Context = context;
            this.Formatter = formatter;
            this.StreamOut = new StreamWriter(path.CreateParentIfMissing().FullPath,false);
        }
    
        public void Write(params AsmFunction[] src)
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