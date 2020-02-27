//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    using Z0.Asm;

    using static zfunc;

    readonly struct AsmFunctionEmitter : IAsmFunctionEmitter
    {
        public IAsmContext Context {get;}

        [MethodImpl(Inline)]
        public static IAsmFunctionEmitter Create(IAsmContext context)
            => new AsmFunctionEmitter(context);

        [MethodImpl(Inline)]
        AsmFunctionEmitter(IAsmContext context)
        {
            this.Context = context;
        }

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