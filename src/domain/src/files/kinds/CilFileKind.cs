//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct FileKinds
    {
        [FileKind]
        public readonly struct Cil : IFileKind<Cil>
        {
            public const string Id = nameof(Cil);
        }    
    }
}