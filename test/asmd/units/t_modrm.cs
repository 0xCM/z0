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

            var identifers = OpCodeApi.identifiers();
            var sample = identifers.Slice(0,math.min(100, identifers.Length));
            Control.iter(sample,s => Trace(s.Format()));
        }

        public void meta_reader()
        {
            var assembly = Parts.AsmD.Resolved.Owner;
            using var reader = MetaReader.Init(assembly.Location);
            var data = reader.ReadUserStrings();
            //Trace($"Read {data.Length} records");

            
            var sample = data.Slice(0,math.min(50, data.Length));
            for(var i=0; i<sample.Length; i++)
            {
                ref readonly var field = ref Control.skip(sample,i);
                var rendered = field.Format();
                //Trace(rendered);
            }
        }


    }
}