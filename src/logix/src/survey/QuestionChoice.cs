//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Defines a choice in the context of a survey question
    /// </summary>
    /// <typeparam name="T">The primal survey representation type</typeparam>
    public readonly struct QuestionChoice<T> : IFormattable<QuestionChoice<T>>
        where T : unmanaged
    {        
        /// <summary>
        /// Uniquely identifies a choice relative to a question
        /// </summary>
        public T Id {get;}
        
        /// <summary>
        /// The meaning of the choice
        /// </summary>
        public string Label {get;}

        public string Title {get;}

        [MethodImpl(Inline)]
        public QuestionChoice(T Id, string Label, string title = null)
        {
            this.Id = Id;
            this.Label = Label;
            this.Title = title ?? $"{gmath.log2(Id)}: {Label}";
        }
                 
        public string Format()
            => text.parenthetical(Title);

        
        public override string ToString()
            => Format();
    }
}