//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
        
    public interface IFileModel<A> : ITextual
        where A : unmanaged, IAsciSequence
    {


    }

    public interface IFileExt<A> : IFileModel<A>
        where A : unmanaged, IAsciSequence

    {
        A Name {get;}
    }

    /// <summary>
    /// Defines an asci-parametric file extension, for when 4 characters just won't cut it
    /// </summary>
    public readonly struct FileExt<A> : IFileExt<A>
        where A : unmanaged, IAsciSequence
    {        
        public A Name {get;}
        
        // [MethodImpl(Inline)]
        // public static implicit operator FileExt<A>(string src)           
        //     => new FileExt<A>(asci.encode(src));


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