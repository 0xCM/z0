//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using System.Linq;

    using static Konst;

    public readonly struct OpCodeRecordSets<T>
    {
        readonly OpCodeRecordSet<T>[] Data;

        [MethodImpl(Inline)]
        public OpCodeRecordSets(params OpCodeRecordSet<T>[] src)
        {
            Data = src;
        }

        public OpCodeRecordSet<T>[] Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public int Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }
    }
}