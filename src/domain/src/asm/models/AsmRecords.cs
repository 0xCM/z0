//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct AsmRecords
    {
        readonly AsmRecord[] Data;

        [MethodImpl(Inline)]
        public static AsmRecordSet<T> set<T>(T key, AsmRecord[] src)
            => new AsmRecordSet<T>(key,src);

        [MethodImpl(Inline), Op, Closures(UInt32k)]
        public static AsmTableSeg<T> segment<T>(T key, ArraySegment<AsmRecord> src)
            => new AsmTableSeg<T>(key,src);

        [MethodImpl(Inline)]
        public static AsmRecordSets<T> sets<T>(AsmRecordSet<T>[] src)
            => new AsmRecordSets<T>(src);

        [MethodImpl(Inline)]
        public static AsmRecords from(AsmRecord[] src)
            => new AsmRecords(src);
            
        [MethodImpl(Inline)]
        public static implicit operator AsmRecords(AsmRecord[] src)
            => new AsmRecords(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmRecord[](AsmRecords src)
            => src.Data;

        [MethodImpl(Inline)]
        public AsmRecords(AsmRecord[] src)
        {
            Data = src;
        }

        public AsmRecord[] Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }
    }
}