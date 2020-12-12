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

    partial struct Cil
    {
        public readonly struct FunctionWriter : ICilFunctionWriter
        {
            public FS.FilePath Target {get;}

            readonly FormatConfig Config;

            [MethodImpl(Inline)]
            public FunctionWriter(FS.FilePath dst, FormatConfig? config = null)
            {
                Target = dst;
                Config = config ?? FormatConfig.Default;
            }

            FunctionFormatter Formatter
            {
                [MethodImpl(Inline)]
                get =>  new FunctionFormatter();
            }

            public void Write(CilFunctionInfo[] src)
            {
                try
                {
                    if(src.Length != 0)
                    {
                        Target.FolderPath.Create();
                        using var writer = new StreamWriter(Target.Name, false);

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
}