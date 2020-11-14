//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IScriptVarValue : ITextual, INullity
    {

    }

    [Free]
    public interface IScriptVarValue<T> : IScriptVarValue, IContented<T>
    {

    }
}