//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IPeFile : IFile
    {

    }

    [Free]
    public interface IPeFile<T> : IPeFile
        where T : struct, IPeFile<T>
    {

    }

}