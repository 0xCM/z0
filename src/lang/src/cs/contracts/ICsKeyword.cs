//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang.Cs
{
    using System;
    using Microsoft.CodeAnalysis.CSharp;

    public interface ICsKeyword<T> : IKeyword<SyntaxKind,T>
        where T : struct, ICsKeyword<T>
    {

    }
}