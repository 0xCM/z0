//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Blit;

    public readonly struct FileFlow : IDataFlow<TypedFile,TypedFile>
    {
        readonly text15 _Actor;

        public TypedFile Source {get;}

        public TypedFile Target {get;}

        [MethodImpl(Inline)]
        public FileFlow(TypedFile src, TypedFile dst)
        {
            _Actor = text15.Empty;
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public FileFlow(string actor, TypedFile src, TypedFile dst)
        {
            _Actor = actor;
            Source = src;
            Target = dst;
        }

        public string Actor
        {
            [MethodImpl(Inline)]
            get => _Actor.Format();
        }

        public string Format()
            => _Actor.IsEmpty
            ? string.Format("{0} -> {1}", Source, Target)
            : string.Format("{0}[{1} -> {2}]", Actor, Source, Target);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator FileFlow((TypedFile src, TypedFile dst) x)
            => new FileFlow(x.src,x.dst);
    }
}