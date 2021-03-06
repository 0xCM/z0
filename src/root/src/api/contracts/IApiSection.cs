//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IApiSection : ITextual
    {
        string Name {get;}

        string ITextual.Format()
            => Name ?? string.Empty;
    }
}