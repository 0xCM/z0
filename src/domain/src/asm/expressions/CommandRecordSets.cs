//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CommandRecordSets<T>
    {
        readonly CommandRecordSet<T>[] Data;

        [MethodImpl(Inline)]
        public CommandRecordSets(params CommandRecordSet<T>[] src)
        {
            Data = src;
        }

        public CommandRecordSet<T>[] Content
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