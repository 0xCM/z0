//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public interface IClrArtifact<T>
    {
        T Subject {get;}
    }

    public interface IClrArtifact<H,T> : IClrArtifact<T>
        where H : struct, IClrArtifact<H,T>
    {

    }

}