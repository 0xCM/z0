//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Reflection;

    using static Konst;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IClrMember
    {
        MemberInfo Definition {get;}
    }

    [Free]
    public interface IClrMember<D> : IClrMember
        where D : MemberInfo

    {
        new D Definition {get;}

        MemberInfo IClrMember.Definition
            => Definition;
    }

    [Free]
    public interface IClrMember<H,D> : IClrMember<D>
        where D : MemberInfo
        where H : struct, IClrMember<H,D>
    {

    }
}