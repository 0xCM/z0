//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    partial class gmathops
    {

        public static uint add_sdel_u32(uint a, uint b)
            => SDel.add<uint>().Invoke(a,b);
    
        public static uint add_gdel_u32(uint a, uint b)
        {
            var add = GDel.add<uint>();            
            var mul = GDel.mul<uint>();
            var xor = GDel.xor<uint>();
            var sub = GDel.sub<uint>();
            var result = 0u;
            result = add(a,b);
            result = mul(result, 9);
            result = xor(result, 8);
            result = sub(result, 4);
            result = mul(result, b);
            result = xor(result, b);
            result = sub(result, b);
            return result;
        }


        public static uint sub_gdel_u32(uint a, uint b)
            => GDel.sub<uint>()(a,b);

    }

}