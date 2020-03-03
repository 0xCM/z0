//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public abstract class SourceCode
    {
        public string Text {get;}

        protected SourceCode(string Text)
            => this.Text = Text;
        
        public string Format()
            => Text;
        
        public override string ToString()
            => Format();
    }
    
    public abstract class SourceCode<T> : SourceCode
        where T : SourceCode<T>, new()
    {
        protected SourceCode(string Text)
            : base(Text)
        {

        }
    }
}