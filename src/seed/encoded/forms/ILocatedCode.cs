//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ILocatedCode<F,C> : IEncoded<F,C>, IAddressable
        where F : struct, IEncoded<F,C>
    {
        /// <summary>
        /// The memory segment occupied by the encoded data := addess + length
        /// </summary>
        MemoryRange MemorySegment
            => (Address, Address + (MemoryAddress)Length);
    }
}