//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
    
    public class t_regiser : t_asmd<t_regiser>
    {
        public void xmm_register_list()
        {
            var index = XmmRegs.Create();
            var locations = index.Locations;
            var data = index.Data;
            var @base = Control.head(locations);
            for(var i=0; i<locations.Length; i++)
            {
                var address = Control.skip(locations,i);
                var offset = address - @base;
                var reg = Control.skip(data,i);
                term.print($"{address} | {offset} | {reg.Kind}");
            }
            
        }
    }
}
