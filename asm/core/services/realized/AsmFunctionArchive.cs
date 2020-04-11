//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Seed;

    public class AsmFunctionArchive : IAsmFunctionArchive
    {        
        public FolderPath RootFolder {get;}
        
        public PartId SourcePart {get;}


        public ApiHostUri ApiHost {get;}
    
        readonly IAsmFormatter AsmFormatter;

        readonly ICilFunctionFormatter CilFormatter;

        readonly AsmEmissionPaths EmissionPaths;

        readonly bool Imm;


        [MethodImpl(Inline)]
        public static IAsmFunctionArchive ImmArchive(IContext context, ApiHostUri host, IAsmFormatter formatter, FolderPath dst)
            => new AsmFunctionArchive(context, host, true, formatter, dst);

        [MethodImpl(Inline)]
        public static IAsmFunctionArchive Create(IContext context, PartId catalog, string host, IAsmFormatter formatter)
            => new AsmFunctionArchive(context, catalog, host, formatter);

        AsmFunctionArchive(IContext context, ApiHostUri host, bool imm, IAsmFormatter formatter, FolderPath dst)
        {
            this.Imm = true;
            this.EmissionPaths = AsmEmissionPaths.Define(dst);
            this.SourcePart = host.Owner;
            this.ApiHost = host;
            this.RootFolder = EmissionPaths.ImmSubDir(RelativeLocation.Define(host.Owner.Format(), host.Name));
            this.AsmFormatter = formatter;
            this.CilFormatter = context.CilFormatter();
        }
        
        AsmFunctionArchive(IContext context, PartId catalog, string hostname, IAsmFormatter formatter)
        {
            this.Imm = false;
            this.EmissionPaths = context.EmissionPaths();
            this.SourcePart = catalog;
            this.ApiHost = ApiHostUri.Define(catalog, hostname);
            this.RootFolder = context.EmissionPaths().DataSubDir(RelativeLocation.Define(catalog.Format(), hostname));
            this.AsmFormatter = formatter;
            this.CilFormatter = context.CilFormatter();
        }

        public void Save(AsmFunctionGroup src, bool append)
        {            
            SaveHex(src, append);
            SaveAsm(src, append);
        }

        public IAsmFunctionArchive Clear()
        {
            RootFolder.Clear();
            return this;
        }

        public Option<FilePath> SaveHex(AsmFunction[] src, bool append, FileName file)    
        {
            try
            {
                var idpad = src.Select(f => f.OpId.Identifier.Length).Max() + 1;
                var dst = HexRoot + file;
                using var writer = new StreamWriter(dst.FullPath, append);                
                for(var i=0; i<src.Length; i++)
                {
                    ref readonly var f = ref src[i];
                    if(f.IsNonEmpty)
                        writer.WriteLine(f.Code.Format(idpad));
                }
                return dst;
            }
            catch(Exception e)
            {
                term.error(e);
                return Option.none<FilePath>();
            }
        }

        public Option<FilePath> SaveAsm(AsmFunction[] src, bool append, FileName file)
        {            
            try
            {
                var idpad = src.Select(f => f.OpId.Identifier.Length).Max() + 1;
                var dst = AsmRoot + file;
                using var writer = new StreamWriter(dst.FullPath, append);                
                for(var i=0; i<src.Length; i++)
                {
                    ref readonly var f = ref src[i];
                    if(f.IsNonEmpty)
                        writer.Write(AsmFormatter.FormatFunction(f));
                }
                return dst;                
            }
            catch(Exception e)
            {
                term.error(e);
                return Option.none<FilePath>();
            }
        }

        Option<FilePath> SaveHex(AsmFunctionGroup src, bool append, FileName file = null)
        {
            try
            {
                var idpad = src.Members.Select(f => f.OpId.Identifier.Length).Max() + 1;
                var dst = FileName.IsSome(file) ? (HexRoot + file) : HexPath(src.Id);
                using var writer = new StreamWriter(dst.FullPath, append);                
                foreach(var f in src.Members)
                {
                    if(f.IsNonEmpty)
                        writer.WriteLine(f.Code.Format(idpad));
                }                    
                return dst;
            }
            catch(Exception e)
            {
                term.error(e);
                return Option.none<FilePath>();
            }
        }

        Option<FilePath> SaveAsm(AsmFunctionGroup src, bool append, FileName file = null)
        {            
            try
            {
                var dst = FileName.IsSome(file) ? (AsmRoot + file) : AsmPath(src.Id);
                using var writer = new StreamWriter(dst.FullPath, append);            
                for(var i=0; i < src.Members.Length;i++)
                {
                    var f = src.Members[i];
                    if(f.IsNonEmpty)
                        writer.Write(AsmFormatter.FormatFunction(f));
                }
                return dst;                
            }
            catch(Exception e)
            {
                term.error(e);
                return Option.none<FilePath>();
            }
        }

        FolderPath HexRoot => EmissionPaths.HexRootDir(SourcePart, ApiHost, Imm).CreateIfMissing();

        FolderPath AsmRoot => EmissionPaths.AsmRootDir(SourcePart, ApiHost, Imm).CreateIfMissing();

        FilePath HexPath(OpIdentity id)
            => EmissionPaths.OpArchivePath(ArchiveFileKind.Hex, SourcePart, ApiHost, id, Imm).CreateParentIfMissing();

        FilePath AsmPath(OpIdentity id)
            => EmissionPaths.OpArchivePath(ArchiveFileKind.Asm, SourcePart, ApiHost, id, Imm).CreateParentIfMissing();

        FilePath CilPath(OpIdentity id)
            => EmissionPaths.OpArchivePath(ArchiveFileKind.Cil, SourcePart, ApiHost, id, Imm).CreateParentIfMissing();
    }
}