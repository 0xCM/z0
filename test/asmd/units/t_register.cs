//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
    
    using Dsl;

    public class t_regiser : t_asmd<t_regiser>
    {
        public void xmm_register_list()
        {
            var index = XmmRegs.Create();
            var locations = index.Locations;
            var data = index.Data;
            var @base = Root.head(locations);
            for(var i=0; i<locations.Length; i++)
            {
                var address = Root.skip(locations,i);
                var offset = address - @base;
                var reg = Root.skip(data,i);
                term.print($"{address} | {offset} | {reg.Kind}");
            }
            
        }
    }
}
