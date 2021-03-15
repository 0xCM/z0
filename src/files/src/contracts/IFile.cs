//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IFile : ITextual
    {
        FS.FilePath Path {get;}

        string ITextual.Format()
            => Path.Name;
    }

    /// <summary>
    /// Characterizes a classifiable file
    /// </summary>
    /// <typeparam name="K">The classifier type</typeparam>
    [Free]
    public interface IFile<F,K> : IFile
        where F : struct, IFile<F,K>
        where K : struct, IFileKind<K>
    {

    }
}