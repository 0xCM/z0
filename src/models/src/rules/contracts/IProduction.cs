//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Rules
    {
        public interface IProduction : ITerm
        {
            Label Name {get;}

            OneOf Expansion {get;}
        }

        public interface IProduction<T> : IProduction, ITerm<T>
        {
            new OneOf<T> Expansion {get;}

            OneOf IProduction.Expansion
                => Expansion;
        }
    }
}