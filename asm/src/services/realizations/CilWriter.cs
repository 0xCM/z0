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
    using System.Runtime.CompilerServices;

    using static zfunc;

    readonly struct CilWriter : ICilWriter
    {
        public IAsmContext Context {get;}
        
        public FilePath Target {get;}
        
        [MethodImpl(Inline)]
        public static CilWriter Create(IAsmContext context, FilePath dst)
            => new CilWriter(context,dst);

        public Option<Exception> WriteCil(AsmFunctionGroup src)        
            => Write(src.Members.Where(f => f.Cil.IsSome()).Select(x => x.Cil.Require()).ToArray());
        
        public Option<Exception> WriteCil(IEnumerable<AsmFunction> functions)
            => Write(functions.Where(f => f.Cil.IsSome()).Select(x => x.Cil.Require()).ToArray());

        [MethodImpl(Inline)]
        CilWriter(IAsmContext context, FilePath dst)            
        {
            this.Context = context;
            this.Target = dst;
        }

        Option<Exception> Write(CilFunction[] cilfuncs)
        {
            try
            {
                if(cilfuncs.Length != 0)
                {
                    Target.FolderPath.CreateIfMissing();
                    using var writer = new StreamWriter(Target.FullPath, false);
                    
                    if(Context.CilFormat.EmitFileHeader)                        
                        writer.WriteLine($"; {now().ToLexicalString()}"); 
                    
                    var formatter = Context.CilFormatter();
                    foreach(var f in cilfuncs)
                    {
                        writer.WriteLine(formatter.Format(f));
                        if(Context.CilFormat.EmitSectionDelimiter)
                            writer.WriteLine(Context.CilFormat.SectionDelimiter);
                    }
                }
                return default;
            }
            catch(Exception e)
            {
                return e;
            }
        }        
    }
}