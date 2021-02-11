//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public sealed class AsmRecords
    {
        public AsmRowSets<IceMnemonic> RowSets {get;private set;}

        public Index<AsmJmpRow> Jumps {get;private set;}

        public Index<AsmCallRow> Calls {get;private set;}

        AsmRecords()
        {
            RowSets = AsmRowSets<IceMnemonic>.Empty;
            Jumps = Index<AsmJmpRow>.Empty;
            Calls = Index<AsmCallRow>.Empty;
        }

        internal AsmRecords(AsmRowSets<IceMnemonic> rows, Index<AsmJmpRow> jumps, Index<AsmCallRow> calls)
        {
            RowSets = rows;
            Jumps = jumps;
            Calls = calls;
        }

        internal AsmRecords With(AsmRowSets<IceMnemonic> src)
        {
            RowSets = src;
            return this;
        }

        internal AsmRecords With(Index<AsmJmpRow> src)
        {
            Jumps = src;
            return this;
        }

        internal AsmRecords With(Index<AsmCallRow> src)
        {
            Calls = src;
            return this;
        }


        public static AsmRecords Empty
            => new AsmRecords();

    }
}