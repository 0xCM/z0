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

        readonly IAsmFunctionFormatter Formatter;


        [MethodImpl(Inline)]
        public static IAsmFunctionEmitter Create(IAsmContext context, IAsmFunctionFormatter formatter)
            => new AsmFunctionEmitter(context,formatter);

        [MethodImpl(Inline)]
        AsmFunctionEmitter(IAsmContext context, IAsmFunctionFormatter formatter)
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
                    dst.Write(Formatter.FormatDetail(functions[i]));
                return default;
            }
            catch(Exception e)
            {
                return e;
            }
        }        
    }
}