//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{

    /// <summary>
    /// Represents an abstract syntax tree as described by https://en.wikipedia.org/wiki/Abstract_syntax_tree
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Ast<T>
        where T : Ast<T>, new()
    {

    }
}