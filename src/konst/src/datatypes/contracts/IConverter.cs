//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IConverter
    {
        Type SourceType {get;}

        Type TargetType {get;}
    }

    /// <summary>
    /// Characterizes a two-way converter
    /// </summary>
    /// <typeparam name="A">The source type</typeparam>
    /// <typeparam name="B">The target type</typeparam>
    public interface IConverter<A,B> : IConverter
    {
        Type IConverter.SourceType
            => typeof(A);

        Type IConverter.TargetType
            => typeof(B);

        bool Convert(in A src, out B dst);

        bool Convert(in B src, out A dst);
    }
}