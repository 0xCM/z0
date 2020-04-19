//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    public interface ICheckAction : ITestChecker
    {
        /// <summary>
        /// Manages the execution of an identified action that performs a validation exercise
        /// </summary>
        /// <param name="f">The action under test</param>
        /// <param name="id">The action identity</param>
        void CheckAction(Action f, OpIdentity id);

        /// <summary>
        /// Manages the execution of an action that performs a validation exercise
        /// </summary>
        /// <param name="f">The action under test</param>
        /// <param name="name">The action name</param>
        void CheckAction(Action f, string name);        
    }
}