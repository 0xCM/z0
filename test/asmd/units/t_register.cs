//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using R = Registers;
    
    public class t_regiser : t_asmd<t_regiser>
    {
        void register_bitfield()
        {
            //term.print(Unsafe.SizeOf<XmmRegs>());            
            var index = XmmRegs.Index;
            var locations = index.Locations;
            var data = index.Data;
            var @base = Control.head(locations);
            var ops = index.Operations;
            for(var i=0; i<locations.Length; i++)
            {
                var current = Control.skip(locations,i);
                var offset = current - @base;
                var value = Control.skip(data,i);
                var f = Control.skip(ops,i);
                

                //term.print($"{current.FormatAsmHex()} | {offset} | {value} | {f.Kind}");
            }
            
        }
    }
}
