//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITypedLiteralType
    {
        LiteralKind LiteralKind {get;}
    }

    /// <summary>
    /// Characterizes a typed literal type definition
    /// </summary>
    /// <typeparam name="H">The reified typed literal</typeparam>
    public interface ITypedLiteralType<H> : ITypedLiteralType
        where H : struct, ITypedLiteralType<H>
    {

    }

    /// <summary>
    /// Characterizes a typed literal type definition
    /// </summary>
    /// <typeparam name="H">The reified typed literal</typeparam>
    /// <typeparam name="L">The literal type</typeparam>
    public interface ITypedLiteralType<H,L> : ITypedLiteralType<H>
        where H : struct, ITypedLiteralType<H,L>
    {
        L LiteralValue {get;}
    }
}