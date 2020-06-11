//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct OpCodeRecords
    {
        [MethodImpl(Inline)]
        public static OpCodeRecordSet<T> Set<T>(T key, CommandInfo[] src)
            => new OpCodeRecordSet<T>(key,src);

        [MethodImpl(Inline)]
        public static OpCodeRecordSets<T> Sets<T>(OpCodeRecordSet<T>[] src)
            => new OpCodeRecordSets<T>(src);

        [MethodImpl(Inline)]
        public static OpCodeRecords Records(CommandInfo[] src)
            => new OpCodeRecords(src);
        
        readonly CommandInfo[] Data;
    
        [MethodImpl(Inline)]
        public static implicit operator OpCodeRecords(CommandInfo[] src)
            => new OpCodeRecords(src);

        [MethodImpl(Inline)]
        public static implicit operator CommandInfo[](OpCodeRecords src)
            => src.Data;

        [MethodImpl(Inline)]
        public OpCodeRecords(CommandInfo[] src)
        {
            Data = src;
        }

        public CommandInfo[] Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }
    }
}