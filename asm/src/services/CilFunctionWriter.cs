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
    using System.Runtime.CompilerServices;
    
    using Z0.Asm;

    using static zfunc;

    readonly struct CilFunctionWriter : ICilFunctionWriter
    {
        public IAsmContext Context {get;}
        
        public FilePath Target {get;}
        
        [MethodImpl(Inline)]
        public static CilFunctionWriter Create(IAsmContext context, FilePath dst)
            => new CilFunctionWriter(context,dst);

        public Option<Exception> WriteCil(AsmFunctionGroup src)        
            => Write(src.Members.Where(f => f.Cil.IsSome()).Select(x => x.Cil.Require()).ToArray());
        
        public Option<Exception> WriteCil(IEnumerable<AsmFunction> functions)
            => Write(functions.Where(f => f.Cil.IsSome()).Select(x => x.Cil.Require()).ToArray());

        [MethodImpl(Inline)]
        CilFunctionWriter(IAsmContext context, FilePath dst)            
        {
            this.Context = context;
            this.Target = dst;
        }

        ICilFunctionFormatter Formatter
        {
            [MethodImpl(Inline)]
            get => Context.CilFormatter();
        }

        public void Write(CilFunction src)
            => throw new NotImplementedException();

        Option<Exception> Write(CilFunction[] src)
        {
            try
            {
                if(src.Length != 0)
                {
                    Target.FolderPath.CreateIfMissing();
                    using var writer = new StreamWriter(Target.FullPath, false);
                    
                    if(Context.CilFormat.EmitFileHeader)                        
                        writer.WriteLine($"; {now().ToLexicalString()}"); 
                    
                    foreach(var f in src)
                    {
                        writer.WriteLine(Formatter.Format(f));
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