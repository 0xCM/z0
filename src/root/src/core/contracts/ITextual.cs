//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITextual
    {
        string Format();
    }


    public interface ILexical : ITextual
    {
        int CompareTo(ILexical src)
            => Format().CompareTo(src.Format());
    }

    public interface ILexical<T> : ILexical, IComparable<T>
        where T : ILexical<T>, ITextual
    {
        int IComparable<T>.CompareTo(T src)
            => Format().CompareTo(src.Format());
    }

    /// <summary>
    /// Characterizes a type that formats a parametrically-specified type
    /// </summary>
    public interface ITextual<F> : ITextual
        where F : ITextual<F>
    {

    }

    public interface ITextual<F,C> : ITextual<F>
        where F : ITextual<F,C>
        where C : struct
    {
        string Format(C config);
    }
}