//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;


    [SuppressUnmanagedCodeSecurity]
    public delegate FixedPoint<Fixed8> PointedEmitter8();

    [SuppressUnmanagedCodeSecurity]
    public delegate FixedPoint<Fixed16> PointedEmitter16();

    [SuppressUnmanagedCodeSecurity]
    public delegate FixedPoint<Fixed32> PointedEmitter32();

    [SuppressUnmanagedCodeSecurity]
    public delegate FixedPoint<Fixed64> PointedEmitter64();

    [SuppressUnmanagedCodeSecurity]
    public delegate FixedPoint<Fixed128V> PointedEmitter128V();

    [SuppressUnmanagedCodeSecurity]
    public delegate FixedPoint<Fixed256V> PointedEmitter256V();

    [SuppressUnmanagedCodeSecurity]
    public delegate FixedPoint<Fixed512> PointedEmitter512V();

}