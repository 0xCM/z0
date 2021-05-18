//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static core;

    public class t_memory : t_core<t_memory>
    {
        Index<ulong> Buffer;


        uint Count;

        public t_memory()
        {
            Buffer = alloc<ulong>(Pow2.T14);
            Count = Buffer.Count;
            Random.Fill(Buffer);
        }

        public unsafe void t_pinned_index()
        {
            var storage = alloc<ulong>(Count);
            using var pinned = memory.pin(storage);
            var data = pinned.Edit;
            var half = Count/2;
            var left = slice(data, 0, half);
            var right = slice(data, half, half);

            slice(Buffer.View,0, half).CopyTo(left);
            slice(Buffer.View,0, half).CopyTo(right);

            ref var a = ref pinned.First;
            ref var b = ref seek(pinned.First, half);
            var pA = gptr(a);
            var pB = gptr(b);
            var matched = bit.On;
            for(var i=0; i<half; i++)
                matched &= (pA[i] == pB[i]);

            Claim.require(matched);
        }
    }
}
