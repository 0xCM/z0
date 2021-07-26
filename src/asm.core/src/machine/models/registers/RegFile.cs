//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct RegModels
    {
        /// <summary>
        /// Defines a squence of register seqeunces
        /// </summary>
        public readonly struct RegFile
        {
            /// <summary>
            /// A surrogate key
            /// </summary>
            public uint Id {get;}

            readonly Index<RegSeqSpec> Data;

            public uint SeqCount
            {
                [MethodImpl(Inline)]
                get => Data.Count;
            }

            [MethodImpl(Inline)]
            internal RegFile(uint seq, RegSeqSpec[] specs)
            {
                Id = seq;
                Data = specs;
            }

            public Span<RegSeqSpec> Specs
            {
                [MethodImpl(Inline)]
                get => Data.Edit;
            }

            [MethodImpl(Inline)]
            public ref RegSeqSpec Spec(uint seq)
                => ref Data[seq];
        }
    }
}