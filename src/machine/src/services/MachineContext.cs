//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using Z0.Asm;

    using static Seed;
    using static Memories;

    public interface IMachineContext : IContext
    {
        PartId[] CodeParts {get;}

        FolderPath CodeRoot {get;}

        //IHostBitsArchive CodeArchive {get;}

        Paired<ApiHostUri,FilePath>[] CodeFiles {get;}
    }


    class MachineContext : IMachineContext
    {
        static IEnumerable<Paired<ApiHostUri,FilePath>> CodeFilePairs(PartId[] parts, FolderPath src) 
            => from part in parts
                from file in src.Files(part, FileExtensions.Hex)
                let host = file.FileHost()
                where !host.IsEmpty
                let p = new Paired<ApiHostUri,FilePath>(host,file)
                select p;

        [MethodImpl(Inline)]
        public static IMachineContext Create(IAsmContext root, PartId[] code)
            => new MachineContext(root,code);
        
        [MethodImpl(Inline)]
        MachineContext(IAsmContext root, PartId[] code)
        {
            CodeParts = code.Length == 0 ? Enums.literals<PartId>().Map(x => x.Value) : code;
            RootContext = root;
            CodeRoot = Archives.Services.CaptureArchive(root.AppPaths.ForApp(PartId.Control).AppCapturePath).HexDir;
            CodeFiles = CodeFilePairs(CodeParts, CodeRoot).ToArray();
        }

        readonly IAsmContext RootContext;

        public PartId[] CodeParts {get;}

        public FolderPath CodeRoot {get;}

        //public IHostBitsArchive CodeArchive {get;}

        public Paired<ApiHostUri,FilePath>[] CodeFiles {get;}
    }
}