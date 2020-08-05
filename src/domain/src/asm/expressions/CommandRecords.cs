//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CommandRecords
    {
        [MethodImpl(Inline)]
        public static CommandRecordSet<T> Set<T>(T key, AsmRecord[] src)
            => new CommandRecordSet<T>(key,src);

        [MethodImpl(Inline)]
        public static CommandRecordSets<T> Sets<T>(CommandRecordSet<T>[] src)
            => new CommandRecordSets<T>(src);

        [MethodImpl(Inline)]
        public static CommandRecords Records(AsmRecord[] src)
            => new CommandRecords(src);
        
        readonly AsmRecord[] Data;
    
        [MethodImpl(Inline)]
        public static implicit operator CommandRecords(AsmRecord[] src)
            => new CommandRecords(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmRecord[](CommandRecords src)
            => src.Data;

        [MethodImpl(Inline)]
        public CommandRecords(AsmRecord[] src)
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