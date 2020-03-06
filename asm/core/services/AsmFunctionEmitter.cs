//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Root;

    readonly struct AsmFunctionEmitter : IAsmFunctionEmitter
    {
        public IAsmContext Context {get;}

        readonly IAsmFormatter Formatter;

        [MethodImpl(Inline)]
        public static IAsmFunctionEmitter Create(IAsmContext context, IAsmFormatter formatter)
            => new AsmFunctionEmitter(context,formatter);

        [MethodImpl(Inline)]
        AsmFunctionEmitter(IAsmContext context, IAsmFormatter formatter)
        {
            this.Context = context;
            this.Formatter = formatter;
        }

        public Option<Exception> EmitAsm(IEnumerable<AsmFunction> src, FilePath file)        
        {            
            var functions = src.ToArray();
            if(functions.Length == 0)
                return default;
            try
            {
                using var dst = new StreamWriter(file.FullPath, false);
                for(var i=0; i< functions.Length; i++)
                    dst.Write(Formatter.FormatFunction(functions[i]));
                return default;
            }
            catch(Exception e)
            {
                return e;
            }
        }        
    }
}