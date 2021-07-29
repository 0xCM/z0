//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct DomainEnv
    {
        public static FS.FolderPath[] folders(IDomainEnv src)
        {
            var methods = src.GetType().Methods().Returns<FS.FolderPath>().WithArity(0).Concrete();
            return methods.Select(m => (FS.FolderPath)m.Invoke(src,null));
        }
    }
}