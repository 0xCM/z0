//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CommandRecordSet<T>
    {        
        readonly AsmRecord[] Data;
    
        public T Key {get;}

        [MethodImpl(Inline)]
        public static implicit operator AsmRecord[](CommandRecordSet<T> src)
            => src.Data;

        [MethodImpl(Inline)]
        public CommandRecordSet(T key, AsmRecord[] src)
        {
            Key = key;
            Data = src;
        }

        public AsmRecord[] Sequenced
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