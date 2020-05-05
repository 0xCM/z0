//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Seed;

    public interface ITypeReflector
    {
        Type Type {get;}

        PropertyInfo[] StaticProperties 
            => Type.StaticProperties();

        FieldInfo[] DeclaredFields
            => Type.DeclaredFields();
    }

    public interface ITypeReflector<F> : ITypeReflector
    {
        Type ITypeReflector.Type => typeof(F);
    }
}