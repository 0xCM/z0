//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using static zfunc;

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
            => parenthetical($"{gmath.log2(Id)}, {Label}");

        public override string ToString()
            => Title;
    }


}