//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public class t_vmakemask : t_inx<t_vmakemask>
    {
        public void vmakemask_128()
        {
            for(var i=0; i<RepCount; i++)
            {
                var a = Random.BitVector(n16);
                var b = cpu.vmask16u(cpu.vmask128x8u(a));
                Claim.eq(b,a.Content);
            }
        }

        public void vmakemask_256()
        {
            for(var i=0; i<RepCount; i++)
            {
                var a = Random.BitVector(n32);
                var b = cpu.vmask32u(cpu.vmask256x8u(a));
                Claim.eq(b,a.Content);
            }
        }
    }
}