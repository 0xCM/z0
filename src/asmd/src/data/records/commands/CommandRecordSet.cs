//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CommandRecordSet<T>
    {        
        readonly CommandInfo[] Data;
    
        public T Key {get;}

        [MethodImpl(Inline)]
        public static implicit operator CommandInfo[](CommandRecordSet<T> src)
            => src.Data;

        [MethodImpl(Inline)]
        public CommandRecordSet(T key, CommandInfo[] src)
        {
            Key = key;
            Data = src;
        }

        public CommandInfo[] Sequenced
        {
            [MethodImpl(Inline)]
            get => Data.OrderBy(x => x.Sequence);
        }

        public int Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }
    }
}