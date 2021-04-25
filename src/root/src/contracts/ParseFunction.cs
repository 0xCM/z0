//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public delegate Outcome ParseFunction<T>(string src, out T dst);

    public delegate Outcome ParseFunction<S,T>(in S src, out T dst);
}