//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
 
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
                Trace(encoding.Format());

            }

        }


    }
}