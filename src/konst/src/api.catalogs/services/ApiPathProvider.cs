//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    sealed class ApiPathProvider : WfService<ApiPathProvider, IApiPathProvider>, IApiPathProvider
    {
        protected override void OnInit()
        {
            Root = Db.Root;
        }

        public FS.FolderPath Root {get; private set;}
    }
}