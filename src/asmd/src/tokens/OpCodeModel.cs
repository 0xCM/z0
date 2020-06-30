//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static Typed;
    using static V0;
    using static math;
    



    public readonly struct OpCodeModel
    {
        readonly Vector256<ulong> Locations;
        

        [MethodImpl(Inline)]
        public OpCodeModel(string id, string cx, string ix)
        {
            var _id = TextResourceReader.address(id);
            var _cx = TextResourceReader.address(cx);
            var _ix = TextResourceReader.address(ix);
            var lengths = or((ulong)id.Length, sll((ulong)cx.Length,8), sll((ulong)ix.Length,16));
            Locations = vparts(w256,_id,_cx,_ix, lengths);
        }  

        byte S0Length
        {
            [MethodImpl(Inline)]
            get => vcell(v8u(Locations), 23);
        }

        MemoryAddress S0Address
        {
            get => vcell(Locations,0);
        }

        MemoryAddress S1Address
        {
            get => vcell(Locations,1);
        }

        MemoryAddress S2Address
        {
            get => vcell(Locations,2);
        }

        byte S1Length
        {
            [MethodImpl(Inline)]
            get => vcell(v8u(Locations), 24);
        }

        byte S3Length
        {
            [MethodImpl(Inline)]
            get => vcell(v8u(Locations), 25);
        }

        // public ReadOnlySpan<char> Expression
        // {
        //     get => As.cover<char>(S0Address, S0Length);
        // }  
    }
}