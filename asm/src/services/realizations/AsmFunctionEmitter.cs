//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.IO;
    using AsmSpecs;

    using static zfunc;

    readonly struct AsmFunctionEmitter : IAsmFunctionEmitter
    {
        readonly IAsmContext Context;

        public static AsmFunctionEmitter Create(IAsmContext context)
            => new AsmFunctionEmitter(context);

        AsmFunctionEmitter(IAsmContext context)
        {
            this.Context = context;
        }

        public Option<Exception> EmitCil(IEnumerable<AsmFunction> functions, FilePath dst)
            => Context.CilWriter(dst).WriteCil(functions);

        public Option<Exception> EmitAsm(IEnumerable<AsmFunction> src, FilePath file)        
        {            
            var functions = src.ToArray();
            if(functions.Length == 0)
                return default;
            try
            {
                var formatter = Context.AsmFormatter();
                using var dst = new StreamWriter(file.FullPath, false);
                for(var i=0; i< functions.Length; i++)
                    dst.Write(formatter.FormatDetail(functions[i]));
                return default;
            }
            catch(Exception e)
            {
                return e;
            }
        }
        
    }
}