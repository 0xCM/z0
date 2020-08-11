//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct FileKinds
    {
        [FileKind]
        public readonly struct Json : IFileKind<Json>
        {
            public const string Id = nameof(Json);
        }    
    }
}