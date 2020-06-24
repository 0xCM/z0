//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;        

    /// <summary>
    /// Defines an asci-parametric file extension, for when 4 characters just won't cut it
    /// </summary>
    public readonly struct FileExt<A> : IFileExt<A>
        where A : unmanaged, IAsciSequence
    {        
        public A Name {get;}                

        [MethodImpl(Inline)]
        public FileExt(A name)
        {
            Name = name;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Name.Text;
    }
}