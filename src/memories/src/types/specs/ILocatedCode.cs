//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface ILocatedCode<F,C> : IEncoded<F,C>, IAddressable
        where F : struct, IEncoded<F,C>
    {
        /// <summary>
        /// The memory segment occupied by the encoded data := addess + length
        /// </summary>
        MemoryRange MemorySegment
        {
            [MethodImpl(Inline)]
            get => (Address, Address + (MemoryAddress)Length);
        }
    }
}