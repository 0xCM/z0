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
        public static CommandRecordSet<T> Set<T>(T key, CommandInfo[] src)
            => new CommandRecordSet<T>(key,src);

        [MethodImpl(Inline)]
        public static CommandRecordSets<T> Sets<T>(CommandRecordSet<T>[] src)
            => new CommandRecordSets<T>(src);

        [MethodImpl(Inline)]
        public static CommandRecords Records(CommandInfo[] src)
            => new CommandRecords(src);
        
        readonly CommandInfo[] Data;
    
        [MethodImpl(Inline)]
        public static implicit operator CommandRecords(CommandInfo[] src)
            => new CommandRecords(src);

        [MethodImpl(Inline)]
        public static implicit operator CommandInfo[](CommandRecords src)
            => src.Data;

        [MethodImpl(Inline)]
        public CommandRecords(CommandInfo[] src)
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