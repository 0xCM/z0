//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using static BitFieldKey;
    
    enum BitFieldKey : byte
    {
        Part0, Part1, Part2, Part3,
        Part4, Part5, Part6, Part7
    }

    public class t_vcpu_bitfield : t_vcpu<t_vcpu_bitfield>
    {
        public void vcpu_bitfield_basecases()
        {
            
        }

    }

}