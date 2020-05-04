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

    public interface IEncoded<F> : IByteSpanProvider<F>, IEquatable<F>
        where F : struct, IEncoded<F>
    {
        bool IsEmpty {get;}

        bool IsNonEmpty {get;}
    }

    public interface IEncoded<F,C> : IEncoded<F>
        where F : struct, IEncoded<F,C>
    {
        /// <summary>
        /// The encoded data, likely in bytes
        /// </summary>
        C Encoded {get;}
    }

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

    public interface IIdentifiedCode<F,C> : IEncoded<F,C>, IIdentified<OpIdentity>
        where F : struct, IEncoded<F,C>

    {

    }

    /// <summary>
    /// Characterizes identified code with a known address and defining member
    /// </summary>
    /// <typeparam name="F"></typeparam>
    /// <typeparam name="C"></typeparam>
    public interface IMemberCode<F,C> : ILocatedCode<F,C>, IIdentifiedCode<F,C>
        where F : struct, IEncoded<F,C>
    {
        /// <summary>
        /// The defining member
        /// </summary>
        MethodInfo Method {get;}
    }
}