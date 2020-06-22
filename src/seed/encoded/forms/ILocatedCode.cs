//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ILocatedCode<F,C> : IEncoded<F,C>, IAddressable
        where F : struct, IEncoded<F,C>
    {
        MemoryRange MemorySegment
            => (Address, Address + (MemoryAddress)Length);
    }
}