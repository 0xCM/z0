//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using Z0.AsmSpecs;

    using static zfunc;

    readonly struct AsmFunctionWriter : IAsmFunctionWriter
    {        
        readonly StreamWriter StreamOut;

        public IAsmContext Context {get;}

        public FilePath TargetPath {get;}

        [MethodImpl(Inline)]
        public static IAsmFunctionWriter Create(IAsmContext context, FilePath dst)
            => new AsmFunctionWriter(context, dst);
                    
        [MethodImpl(Inline)]
        AsmFunctionWriter(IAsmContext context, FilePath path)
        {
            this.TargetPath = path;
            this.Context = context;
            this.StreamOut = new StreamWriter(path.CreateParentIfMissing().FullPath,false);
        }
    
        public void Write(AsmFunction src)
        {
            StreamOut.Write(Context.AsmFormatter().FormatDetail(src));
        }

        public void Dispose()
        {
            StreamOut.Flush();
            StreamOut.Dispose();
        }
    }
}