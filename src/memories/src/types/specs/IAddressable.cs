//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Characterizes an address-identified target
    /// </summary>
    public interface IAddressable : ITextual
    {
        MemoryAddress Address {get;}
    }            
}