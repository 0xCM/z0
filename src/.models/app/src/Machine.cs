//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using Z0.Asm;

    using static Konst;
    using static Memories;

    public class Machine : IMachine
    {
        public IMachineContext Context {get;}

        Machine(IMachineContext context)
        {
            Context = context;
        }

        public void Run()
        {
            // Create machine parts
            term.print("I do nothing...yet");

        }

        void Describe(FolderPath src, PartId[] code)
        {
            //Control.iter(code, part => Control.iter(src.Files(part), file => Print(file)));            
        }
        
        void Describe(PartId[] code)
        {
            // var archive = Archives.Services.CaptureArchive(Context.CaptureRoot);

            // term.print($"Creating a machine over a code selection from {archive.RootDir}");
            // Describe(archive.HexDir, code);

        }

        public void Dispose()
        {

        }

        public static void Run(IMachineContext context)
        {
            try
            {            
                using var machine = new Machine(context); 
                machine.Run();   
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }
    }

}