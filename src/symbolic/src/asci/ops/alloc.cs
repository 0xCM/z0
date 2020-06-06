//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
     
    using static Seed;
    using static Control;
    using static Typed;

    partial class AsciCodes
    {
        [MethodImpl(Inline), Op]
        public static AsciCode16[] alloc(N16 n, int count)
        {
            var buffer =  new AsciCode16[count];
            Span<AsciCode16> dst = buffer;
            dst.Fill(init(n));
            return buffer;
        }

        [MethodImpl(Inline), Op]
        public static AsciCode32[] alloc(N32 n, int count)
        {
            var buffer =  new AsciCode32[count];
            Span<AsciCode32> dst = buffer;
            dst.Fill(init(n));
            return buffer;
        }

        [MethodImpl(Inline), Op]
        public static AsciCode64[] alloc(N64 n, int count)
        {
            var buffer =  new AsciCode64[count];
            Span<AsciCode64> dst = buffer;
            dst.Fill(init(n));
            return buffer;
        }
    }
}