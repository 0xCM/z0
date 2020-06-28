//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct CilFunctionWriter : ICilFunctionWriter
    {        
        public FilePath Target {get;}

        readonly CilFormatConfig Config;
        
        
        [MethodImpl(Inline)]
        public CilFunctionWriter(FilePath dst, CilFormatConfig config = null)
        {
            Target = dst;
            Config = config ?? CilFormatConfig.Default;
        }

        CilFunctionFormatter Formatter
        {
            [MethodImpl(Inline)]
            get =>  new CilFunctionFormatter();
        }

        public void Write(CilFunction[] src)
        {
            try
            {
                if(src.Length != 0)
                {
                    Target.FolderPath.Create();
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