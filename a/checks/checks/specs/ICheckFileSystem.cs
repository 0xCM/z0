//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public interface ICheckFileSystem : IValidator
    {
        void exists(FilePath path, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Claim.exists(path, caller, file, line);

        void exists(FolderPath path, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Claim.exists(path, caller, file, line);
    }
}