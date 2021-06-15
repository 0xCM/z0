//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IApiSigTypeMod<T> : ITextual
        where T : struct, IApiSigTypeMod<T>
    {
        Name Name {get;}

        ApiSigModKind Kind {get;}
    }
}