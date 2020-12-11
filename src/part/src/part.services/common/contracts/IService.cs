//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes nothing but is a marker for a type that, perhaps, defines something useful to someone
    /// </summary>
    [Free]
    public interface IService
    {
        Type HostType {get;}

        Type ContractType {get;}

        Type[] ContractArgs => new Type[]{};

        byte ParametricArity => (byte)ContractArgs.Length;

        uint Discriminator => 0;

        ServiceSpec Spec
            => new ServiceSpec(HostType, ContractType, Discriminator, ContractArgs);
    }

    /// <summary>
    /// Characterizes a service that extends a parametric context with operational semantics.
    /// </summary>
    /// <typeparam name="C">The context type</typeparam>
    [Free]
    public interface IService<H,C> : IService
        where H : IService<H,C>
        where C : class
    {
        Type IService.HostType => typeof(H);

        Type IService.ContractType => typeof(C);
    }

    public interface IService<H,C,A0> : IService<H,C>
        where H : IService<H,C,A0>
        where C : class
    {
        Type[] IService.ContractArgs => new Type[1]{typeof(A0)};
    }

    public interface IService<H,C,A0,A1> : IService<H,C>
        where H : IService<H,C,A0,A1>
        where C : class
    {
        Type[] IService.ContractArgs => new Type[2]{typeof(A0), typeof(A1)};
    }

    public interface IService<H,C,A0,A1,A2> : IService<H,C>
        where H : IService<H,C,A0,A1,A2>
        where C : class
    {
        Type[] IService.ContractArgs => new Type[3]{typeof(A0), typeof(A1), typeof(A2)};
    }

    public interface IService<H,C,A0,A1,A2,A3> : IService<H,C>
        where H : IService<H,C,A0,A1,A2,A3>
        where C : class
    {
        Type[] IService.ContractArgs => new Type[4]{typeof(A0), typeof(A1), typeof(A2), typeof(A3)};
    }
}