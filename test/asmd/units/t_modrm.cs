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
    using MRK = MetaRecordKinds;
    

    public class t_modrm : t_asmd<t_modrm>
    {
        
        public void modrm_encode()
        {
            var encoder = PrefixEncoders.ModRm;
            Span<ModRmEncoding> dst = new ModRmEncoding[1024];
            var count = encoder.table(dst);
            Claim.eq(256,count);
            
            for(var i=0; i<count; i++)
            {
                ref readonly var encoding = ref skip(dst,i);
                //Trace(encoding.Format());

            }

        }

        public void op_codes()
        {

            // var identifers = OpCodeServices.identifiers();
            // var sample = identifers.Slice(0,math.min(100, identifers.Length));
            // Control.iter(sample,s => Trace(s.Format()));
        }


        public void read_user_strings()
        {            
            //read_metadata(MRK.String);

            var part = Parts.AsmG.Resolved;
            var assembly = part.Owner;
            var dstPath = CasePath("UserStrings");
            var header = MetaFormat.HeaderText(MRK.String);

            using var reader = MetaReader.Init(assembly.Location);
            var src = reader.ReadUserStrings();
            var dst = dstPath.Writer();
            dst.WriteLine(header);
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var value = ref Control.skip(src,i);
                dst.WriteLine(value.Format());
            }
        }


        public void read_fields()
        {            
            //read_metadata(MRK.Field);

            var part = Parts.AsmG.Resolved;
            var assembly = part.Owner;
            var dstPath = CasePath("Fields");
            var header = MetaFormat.HeaderText(MRK.Field);

            using var reader = MetaReader.Init(assembly.Location);
            var src = reader.ReadFields();
            var dst = dstPath.Writer();
            dst.WriteLine(header);
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var value = ref Control.skip(src,i);
                dst.WriteLine(value.Format());
            }
        }

        public void read_metadata<R>(R kind = default)
            where R : unmanaged, IMetaRecordKind
        {                        
            var part = Parts.AsmG.Resolved;
            var assembly = part.Owner;
            var dstPath = CasePath(kind.Format());
            var header = MetaFormat.HeaderText(kind);

            using var reader = MetaReader.Init(assembly.Location);
            var src = reader.Read<R>();
            var dst = dstPath.Writer();
            dst.WriteLine(header);
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var value = ref Control.skip(src,i);
                dst.WriteLine(value.Format());
            }
        }

        public void read_constants()
        {            
            //read_metadata(MRK.Constant);
            var part = Parts.AsmG.Resolved;
            var assembly = part.Owner;
            var dstPath = CasePath("Constants");
            var header = MetaFormat.HeaderText(MRK.Constant);

            using var reader = MetaReader.Init(assembly.Location);
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