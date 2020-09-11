//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes an object that advertises its memory location
    /// </summary>
    public interface IAddressable : ITextual
    {
        MemoryAddress Base {get;}

        string ITextual.Format()
            => Base.Format();
    }

    /// <summary>
    /// Characterizes an object that advertises a parametric memory location
    /// </summary>
    /// <typeparam name="T">The parametric address type</typeparam>
    public interface IAddressable<T> : IAddressable
        where T : unmanaged, IAddress
    {
        new T Base {get;}

        MemoryAddress IAddressable.Base
            => z.convert<T,ulong>(Base);
    }

    /// <summary>
    /// Characterizes a reified addressable object
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="T">The address type</typeparam>
    public interface IAddressable<F,T> : IAddressable<T>
        where F : IAddressable<F,T>, new()
        where T : unmanaged, IAddress
    {

    }
}