//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
 
    using static Seed;
    using static Memories;
    using MS = MetadataSpecs;
    
    public class t_metadata_reader : t_asmd<t_metadata_reader>
    {
        public t_metadata_reader()
        {
            UnitRoot.Clear();   
            DataSources = Control.array<IPart>(Parts.AsmG.Resolved, Parts.AsmD.Resolved, Parts.Symbolic.Resolved);
        }

        IMetadataReader CreateReader(string src)
            => MetadataServices.Reader(FilePath.Define(src));
        
        readonly IPart[] DataSources;
        
        public void read_fields()
        {            
            read_fields(DataSources);
        }

        public void read_constants()
        {            
            read_constants(DataSources);
        }

        public void read_user_strings()
        {            
            read_user_strings(DataSources);
        }

        public void read_blobs()
        {            
            read_blobs(DataSources);
        }

        void read_user_strings(params IPart[] parts)
        {            
            var spec = MS.Strings;
            foreach(var part in parts)
            {
                var assembly = part.Owner;
                var dstPath = CasePath($"{part.Id}.{spec}");
                var header = MetadataFormat.HeaderText(MS.Strings);

                using var reader = CreateReader(assembly.Location);
                var src = reader.ReadUserStrings();
                var dst = dstPath.Writer();
                dst.WriteLine(header);
                for(var i=0; i<src.Length; i++)
                {
                    ref readonly var value = ref Control.skip(src,i);
                    dst.WriteLine(value.Format());
                }
            }
        }

        void read_blobs(params IPart[] parts)
        {            
            var spec = MS.Blobs;
            foreach(var part in parts)
            {
                var assembly = part.Owner;
                var dstPath = CasePath($"{part.Id}.{spec}");
                var header = MetadataFormat.HeaderText(spec);

                using var reader = CreateReader(assembly.Location);
                var src = reader.ReadBlobs();
                var dst = dstPath.Writer();
                dst.WriteLine(header);
                for(var i=0; i<src.Length; i++)
                {
                    ref readonly var value = ref Control.skip(src,i);
                    dst.WriteLine(value.Format());
                }
            }
        }

        void read_fields(params IPart[] parts)
        {            
            var spec = MS.Fields;
            foreach(var part in parts)
            {
                var assembly = part.Owner;
                var dstPath = CasePath($"{part.Id}.{spec}");
                var header = MetadataFormat.HeaderText(MS.Fields);

                using var reader = CreateReader(assembly.Location);
                var src = reader.ReadFields();
                var dst = dstPath.Writer();
                dst.WriteLine(header);
                for(var i=0; i<src.Length; i++)
                {
                    ref readonly var value = ref Control.skip(src,i);
                    dst.WriteLine(value.Format());
                }
            }
        }

        void read_constants(params IPart[] parts)
        {            
            foreach(var part in parts)
            {
                var assembly = part.Owner;
                var dstPath = CasePath($"{part.Id}.Constants");
                var header = MetadataFormat.HeaderText(MS.Constants);

                using var reader = CreateReader(assembly.Location);
                var src = reader.ReadConstants();
                var dst = dstPath.Writer();
                dst.WriteLine(header);
                for(var i=0; i<src.Length; i++)
                {
                    ref readonly var value = ref Control.skip(src,i);
                    dst.WriteLine(value.Format());
                }
            }
        }
    }
}