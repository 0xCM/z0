//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a type-level asci letter
    /// </summary>
    /// <typeparam name="L">The reification type</typeparam>
   public interface IAsciLetter<L> : ILetter<L,AsciLetter,AsciLetterCode>
        where L : unmanaged, IAsciLetter<L>
    {

    }
}