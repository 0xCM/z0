//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface ITypeIdentity : IIdentity
    {

    }
    
    public interface ITypeIdentity<T> : ITypeIdentity, IIdentity<T>
        where T : ITypeIdentity<T>, new()    
    {

    }

    public interface ISegmentedIdentity : ITypeIdentity<SegmentedIdentity>
    {

    }

    public interface IPrimalIdentity : ITypeIdentity<PrimalIdentity>
    {

    }

    public interface IEnumIdentity : ITypeIdentity<EnumIdentity>
    {

    }

    public interface IScalarIdentity : ITypeIdentity<ScalarIdentity>
    {

        
    }

    public interface IParametricIdentity : ITypeIdentity<ParametricIdentity>
    {

    }

}