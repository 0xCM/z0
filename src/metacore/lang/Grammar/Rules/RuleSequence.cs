﻿//-------------------------------------------------------------------------------------------
// OSS developed by Chris Moore and licensed via MIT: https://opensource.org/licenses/MIT
// This license grants rights to merge, copy, distribute, sell or otherwise do with it 
// as you like. But please, for the love of Zeus, don't clutter it with regions.
//-------------------------------------------------------------------------------------------
namespace Meta.Syntax
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
   
    using static metacore;

    public class RuleSequence : SyntaxRule<RuleSequence>
    {
        public RuleSequence(string RuleName = null)
            : base(RuleName)
        {


        }

        public RuleSequence(string RuleName, IEnumerable<SyntaxRule> Terms, string Description = null)
            : base(RuleName, Terms, Description)
        {
        

        }

        public RuleSequence(IEnumerable<SyntaxRule> Terms, string Description = null)
            : base(string.Empty, Terms, Description)
        {


        }

        protected override RuleSequence Define(string RuleName, IEnumerable<SyntaxRule> Terms, string Description)
            => new RuleSequence(RuleName, Terms, Description);

    }
}