//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes something with a name
    /// </summary>
    public interface INamed : ITextual
    {
        StringRef Name {get;}

        string ITextual.Format()
            => Name;
    }

    public interface INamed<F> : INamed
        where F : struct, INamed<F>
    {
        StringRef INamed.Name 
            => typeof(F).Name;
    }
}