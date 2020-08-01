//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Linq;
    using System.Collections.Generic;
    using System.IO;    

    using static Konst;

    /// <summary>
    /// Manages file system command specification persistence
    /// </summary>
    public class CommandFileStore : IContextual<IAppContext>
    {
        public IAppContext Context {get;}

        public FolderPath Root {get;}

        static string BuildSearchPattern(params string[] ext)
            => string.Join(";*.", ext.Length == 0 ? sys.array("*.spec") : ext);

        public CommandFileStore(IAppContext context, FolderPath root)
        {
            Context = context;
            Root = root;
            
        }

        public CommandFileStore(IAppContext C)
        {
            Context = C;

            if (Settings.CommandFolder.Exists)
            {
                this.index = (
                        from path in Settings.CommandFolder.Files(BuildSearchPattern(), SearchOption.AllDirectories)
                        let specOption = serializer.Decode(path.ReadText())
                        where specOption.Exists
                        let spec = specOption.Require()
                        group
                            spec by spec.CommandName into groups
                        select
                            (groups.Key, groups.Array())
                        ).ToDictionary();
             
                this.specs = index.Values.Collapse().Array();
            }
            else
            {
                this.index = new Dictionary<CommandName, ICommandSpec[]>();
                this.specs = sys.empty<ICommandSpec>();
            }
        }

        Dictionary<CommandName, ICommandSpec[]> index {get;}

        ICommandSpec[] specs { get; }

        CommandSystemSettings Settings
            => Context.LoadSettings<CommandSystemSettings>(FileName.Define(nameof(CommandFileStore)));

        ICommandSpecSerializer serializer 
            => Context.Service<ICommandSpecSerializer>();

        Option<ICommandSpec> TryLoadSpec(FilePath path)
        {
            Json json = path.ReadText();
            if (json.IsEmpty)
                return z.none<ICommandSpec>();

            return serializer.Decode(json);
        }

        Option<ICommandSpec> TryFindSpec(FileName specName)
        {
            //The spec may not actually be in the designated store folder but live somewhere else..
            var specPath = Root + specName;
            if (specPath.Exists)
            {
                var spec = TryLoadSpec(specPath);
                return spec;
            }
            else
            {
                var path = Settings.CommandFolder.Files(specName, true).FirstOrDefault();
                return path != null ?
                    serializer.Decode(path.ReadText())
                    : z.none<ICommandSpec>();            
            }
        }

        public ICommandSpec[] FindSpecs()
            => specs;

        public Option<T> FindSpec<T>(FileName specName)
            where T : CommandSpec<T>, new()
                => TryFindSpec(specName).Select(csr => csr as T);

        public Option<ICommandSpec> FindSpec(FileName specName)
            => TryFindSpec(specName);

        public Option<int> SaveSpec(ICommandSpec spec, FileExtension Extension, bool FlattenHierarchy)
        {
            var ext = Extension ?? FileExtension.Define("spec");
            var filename = new FileName(spec.SpecName) + ext;
            var outdir =  FlattenHierarchy 
                    ? Settings.CommandFolder 
                    : Settings.CommandFolder + FolderName.Define(spec.CommandName);

            outdir.Create();

            var path = outdir + filename;
            var json = serializer.Encode(spec);
            path.Ovewrite(json.Content);
            return 1;
        }

        public Option<int> SaveSpecs(IEnumerable<ICommandSpec> specs, FileExtension Extension, bool FlattenHierarchy)
        {
            int count = 0;
            foreach(var spec in specs)
            {
                SaveSpec(spec, Extension, FlattenHierarchy);
                count++;

            }
            return count;        
        }

        public Option<FilePath> ExportSpec(ICommandSpec spec, FolderPath root, FileExtension Extension, bool FlattenHierarchy)
        {

            var ext = Extension ?? FileExtension.Define("spec");
            var dstFolder = FlattenHierarchy ? root : root + RelativeLocation.Define(spec.CommandName.Id.Split('/').Last());
            dstFolder.Create();
            var path = dstFolder + (new FileName(spec.SpecName) + ext);
            var json = serializer.Encode(spec);
            path.Ovewrite(json.Content);
            return path;
        }
    }
}