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

    /// <summary>
    /// Characterizes a type that defines views over captured literals
    /// </summary>
    /// <typeparam name="K">The covered literal type</typeparam>
    public interface ILiteralCover<C>
        where C : struct, ILiteralCover<C>
    {
        FieldInfo[] Covered
            => typeof(C).Fields();
    }

    /// <summary>
    /// Characterizes a type that defines views over captured literals
    /// </summary>
    /// <typeparam name="C">The cover type</typeparam>
    /// <typeparam name="K">The covered literal type</typeparam>
    public interface ILiteralCover<C,K> : ILiteralCover<C>
        where C : struct, ILiteralCover<C,K>
    {

    }

    /// <summary>
    /// Characterizes a type that defines views over captured literals
    /// </summary>
    /// <typeparam name="C">The cover type</typeparam>
    /// <typeparam name="K1">A covered literal type</typeparam>
    /// <typeparam name="K2">A covered literal type</typeparam>
    public interface ILiteralCover<C,K0,K1> : ILiteralCover<C>
        where C : struct, ILiteralCover<C,K0,K1>
    {

    }
}