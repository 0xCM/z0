//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Represents a parsed expression as described in https://en.wikipedia.org/wiki/Parse_tree
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class ParseTree<T> : Tree<T>
        where T : ParseTree<T>, new()
    {

    }
}