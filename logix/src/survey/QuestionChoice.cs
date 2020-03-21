//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a choice in the context of a survey question
    /// </summary>
    /// <typeparam name="T">The primal survey representation type</typeparam>
    public class QuestionChoice<T> 
        where T : unmanaged
    {
        
        [MethodImpl(Inline)]
        public QuestionChoice(T Id, string Label)
        {
            this.Id = Id;
            this.Label = Label;
        }
        
        /// <summary>
        /// Uniquely identifies a choice relative to a question
        /// </summary>
        public T Id {get;}
        
        /// <summary>
        /// The meaning of the choice
        /// </summary>
        public string Label {get;}

        public string Title
            => $"{gmath.log2(Id)}: {Label}";
         
        public string Format()
            => text.parenthetical($"{gmath.log2(Id)}, {Label}");

        public override string ToString()
            => Title;
    }
}