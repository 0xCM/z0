//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ITerm : ITextual
    {

    }

    [Free]
    public interface ITerm<T> : ITerm
    {
        T Value {get;}
    }

    public readonly struct EmptyTerm : ITerm
    {
        public bool IsEmpty => true;
        public string Format()
            => string.Empty;
    }
}