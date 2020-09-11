//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Konst;
    using static z;

    public interface IAsmArgSequence
    {
        /// <summary>
        /// The number of arguments accepted by the operand
        /// </summary>
        byte Count {get;}
    }

    /// <summary>
    /// Characterizes an instruction reification
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IAsmArgSequence<F,N> : IAsmArgSequence
        where F : struct, IAsmArgSequence<F,N>
        where N : unmanaged, ITypeNat
    {
        byte IAsmArgSequence.Count
            => (byte)z.value<N>();
    }


}