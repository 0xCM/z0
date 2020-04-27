//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    public readonly struct CilFunctionWriter : ICilFunctionWriter
    {        
        public FilePath Target {get;}

        readonly CilFormatConfig Config;
        
        [MethodImpl(Inline)]
        public static CilFunctionWriter Create(FilePath dst, CilFormatConfig config = null)
            => new CilFunctionWriter(dst, config ?? CilFormatConfig.Default);
        
        [MethodImpl(Inline)]
        CilFunctionWriter(FilePath dst, CilFormatConfig config)            
        {
            this.Target = dst;
            this.Config = config;
        }

        ICilFunctionFormatter Formatter
        {
            [MethodImpl(Inline)]
            get =>  CilFunctionFormatter.Create();
        }

        public void Write(CilFunction[] src)
        {
            try
            {
                if(src.Length != 0)
                {
                    Target.FolderPath.CreateIfMissing();
                    using var writer = new StreamWriter(Target.FullPath, false);
                    
                    if(Config.EmitFileHeader)                        
                        writer.WriteLine($"; {DateTime.Now}"); 
                    
                    foreach(var f in src)
                    {
                        writer.WriteLine(Formatter.Format(f));
                        if(Config.EmitSectionDelimiter)
                            writer.WriteLine(Config.SectionDelimiter);
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