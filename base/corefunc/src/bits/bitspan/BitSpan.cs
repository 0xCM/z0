//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;


    /// <summary>
    /// Defines an anti-succinct data structure for bit representation
    /// </summary>
    public readonly ref partial struct BitSpan
    {
        readonly Span<bit> bits;

        [MethodImpl(Inline)]
        public BitSpan(Span<bit> bits)
            => this.bits = bits;
        
        public Span<bit> Bits
        {
            [MethodImpl(Inline)]
            get => bits;
        }
    }

}