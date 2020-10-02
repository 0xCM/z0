//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.gCs
{
    using System;
    using Microsoft.CodeAnalysis.CSharp;

    using Z0.Lang;

    public interface ICsKeyword<T> : IKeyword<SyntaxKind,T>
        where T : struct, ICsKeyword<T>
    {

    }

}