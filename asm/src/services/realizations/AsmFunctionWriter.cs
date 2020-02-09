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

    sealed class AsmFunctionWriter : StreamWriter, IAsmFunctionWriter
    {        
        public IAsmContext Context {get;}

        [MethodImpl(Inline)]
        public static IAsmFunctionWriter Create(IAsmContext context, FilePath dst)
            => new AsmFunctionWriter(context, dst);
                    
        [MethodImpl(Inline)]
        AsmFunctionWriter(IAsmContext context, FilePath path)
            : base(path.FullPath, false)
        {
            this.Context = context;
        }
    
        public void Write(AsmFunction src)
        {
            Write(Context.AsmFormatter().FormatDetail(src));
        }
    }
}