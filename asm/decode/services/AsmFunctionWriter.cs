//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Core;

    readonly struct AsmFunctionWriter : IAsmFunctionWriter
    {        
        readonly StreamWriter StreamOut;

        readonly AsmFormatConfig Config;

        readonly IContext Context;

        public FilePath TargetPath {get;}

        [MethodImpl(Inline)]
        public static IAsmFunctionWriter Create(IContext context, AsmFormatConfig config, FilePath dst)
            => new AsmFunctionWriter(context, config, dst);

        [MethodImpl(Inline)]
        AsmFunctionWriter(IContext context, AsmFormatConfig config, FilePath path)
        {
            this.TargetPath = path;
            this.Context = context;
            this.Config = config;
            this.StreamOut = new StreamWriter(path.CreateParentIfMissing().FullPath,false);
        }
    
        public void Write(params AsmFunction[] src)
        {
            foreach(var f in src)
                StreamOut.Write(Context.AsmFormatter(Config).FormatFunction(f));
        }
        
        public void Dispose()
        {
            StreamOut.Flush();
            StreamOut.Dispose();
        }
    }
}