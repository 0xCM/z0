//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes nothing but is a marker for a type that, perhaps, defines something useful to someone
    /// </summary>
    [Free]
    public interface IService
    {
        Type HostType => GetType();

        Type ContractType => GetType();

        Type[] ContractArgs => new Type[]{};

        uint Discriminator => 0;

    }

    /// <summary>
    /// Characterizes reified service
    /// </summary>
    /// <typeparam name="H">The service host type</typeparam>
    [Free]
    public interface IService<H> : IService
        where H : IService<H>, new()
    {
        Type IService.HostType => typeof(H);
    }

    /// <summary>
    /// Characterizes reified service with a parametrically-identified contract
    /// </summary>
    /// <typeparam name="H">The service host type</typeparam>
    /// <typeparam name="C">The contract type</typeparam>
    [Free]
    public interface IService<H,C> : IService<H>
        where H : IService<H,C>, new()
    {
        Type IService.ContractType => typeof(C);
    }

    [Free]
    public interface IService<H,C,A0> : IService<H,C>
        where H : IService<H,C,A0>, new()
    {
        Type[] IService.ContractArgs
            => new Type[1]{typeof(A0)};
    }

    public interface IService<H,C,A0,A1> : IService<H,C>
        where H : IService<H,C,A0,A1>, new()
    {
        Type[] IService.ContractArgs
            => new Type[2]{typeof(A0), typeof(A1)};
    }
}