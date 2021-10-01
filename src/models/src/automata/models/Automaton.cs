//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using static Functions;

    partial struct Automata
    {
        public class Automaton<A,S>
            where A : unmanaged
            where S : unmanaged
        {
            public Alphabet<A> Alphabet {get;}

            public S Initial {get;}

            public States<S> States {get;}

            public States<S> Accepted {get;}

            public BinaryFunction<S,A,S> Transition {get;}

            public Automaton(Alphabet<A> aleph, S s0, States<S> states, States<S> accept)
            {
                Alphabet = aleph;
                Initial = s0;
                States  = states;
                Accepted = accept;
            }
        }
    }
}