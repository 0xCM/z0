//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
     
    using static Konst;
    using static Control;

    partial class AsciCodes
    {

        [MethodImpl(Inline), Op]
        public static asci16[] alloc(N16 n, int count)
        {
            var buffer =  new asci16[count];
            Span<asci16> dst = buffer;
            dst.Fill(init(n));
            return buffer;
        }

        [MethodImpl(Inline), Op]
        public static asci32[] alloc(N32 n, int count)
        {
            var buffer =  new asci32[count];
            Span<asci32> dst = buffer;
            dst.Fill(init(n));
            return buffer;
        }

        [MethodImpl(Inline), Op]
        public static asci64[] alloc(N64 n, int count)
        {
            var buffer =  new asci64[count];
            Span<asci64> dst = buffer;
            dst.Fill(init(n));
            return buffer;
        }
    }
}