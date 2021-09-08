//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Actor<S,T> : IActor<S,T>
    {
        public readonly StringAddress Name;

        public readonly S Source;

        public readonly T Target;

        [MethodImpl(Inline)]
        public Actor(string name, S source, T target)
        {
            Name = name;
            Source = source;
            Target = target;
        }

        [MethodImpl(Inline)]
        public Actor(StringAddress name, S source, T target)
        {
            Name = name;
            Source = source;
            Target = target;
        }

        S IActor<S,T>.Source
            => Source;

        T IActor<S,T>.Target
            => Target;

        string IActor.Name
            => Name.Format();

        public string Format()
            => string.Format("{0}:{1} -> {2}", Name, Source, Target);

        public override string ToString()
            => Format();
    }
}