//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;
    
    using static Core;

    readonly struct CilFunctionWriter : ICilFunctionWriter
    {
        public ICilContext Context {get;}
        
        public FilePath Target {get;}
        
        [MethodImpl(Inline)]
        public static CilFunctionWriter Create(ICilContext context, FilePath dst)
            => new CilFunctionWriter(context,dst);
        

        [MethodImpl(Inline)]
        CilFunctionWriter(ICilContext context, FilePath dst)            
        {
            this.Context = context;
            this.Target = dst;
        }

        ICilFunctionFormatter Formatter
        {
            [MethodImpl(Inline)]
            get => Context.CilFormatter();
        }

        public void Write(CilFunction[] src)
        {
            try
            {
                if(src.Length != 0)
                {
                    Target.FolderPath.CreateIfMissing();
                    using var writer = new StreamWriter(Target.FullPath, false);
                    
                    if(Context.CilFormat.EmitFileHeader)                        
                        writer.WriteLine($"; {time.now().ToLexicalString()}"); 
                    
                    foreach(var f in src)
                    {
                        writer.WriteLine(Formatter.Format(f));
                        if(Context.CilFormat.EmitSectionDelimiter)
                            writer.WriteLine(Context.CilFormat.SectionDelimiter);
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }
        }        
    }
}