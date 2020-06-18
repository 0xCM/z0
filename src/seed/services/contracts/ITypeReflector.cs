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