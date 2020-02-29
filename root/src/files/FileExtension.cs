//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a file extension
    /// </summary>
    public class FileExtension : PathComponent<FileExtension>
    {
        [MethodImpl(Inline)]
        public static FileExtension Define(string name)
            => new FileExtension(name);

        public FileExtension(){}

        public FileExtension(string name)
            : base(name)
        {

        }
    }
}