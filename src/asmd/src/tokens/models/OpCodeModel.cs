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
    using static As;
    using static V0;
    
    using Storage = Vector1024<ulong>;

    public readonly struct OpCodeModel
    {
        //32
        readonly Vector256<ulong> Locations;
        

        [MethodImpl(Inline)]
        public OpCodeModel(string id, string cx, string ix)
        {
            var _id = TextResourceReader.address(id);
            var _cx = TextResourceReader.address(cx);
            var _ix = TextResourceReader.address(ix);
            Locations = vparts(w256,_id,_cx,_ix, 0ul);
        }    
    }
}