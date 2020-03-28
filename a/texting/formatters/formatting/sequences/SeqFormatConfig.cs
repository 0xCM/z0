//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Textual;

    public readonly struct SeqFormatConfig : ISeqFormatConfig
    {
        [MethodImpl(Inline)]
        public static SeqFormatConfig<C> Define<C>(C c)
            where C : ISeqFormatConfig
            => new SeqFormatConfig<C>(c);

        [MethodImpl(Inline)]
        public static SeqFormatConfig Define(string delimiter)
            => new SeqFormatConfig(delimiter);
        
        [MethodImpl(Inline)]
        SeqFormatConfig(string delimiter)
        {
            this.Delimiter = delimiter;
        }

        public string Delimiter {get;}

    }

    public readonly struct SeqFormatConfig<C> : ISeqFormatConfig<C>
        where C : ISeqFormatConfig
    {
        [MethodImpl(Inline)]
        internal SeqFormatConfig(C c)
        {
            this.BaseConfig = c;
        }

        public C BaseConfig {get;}

        public string Delimiter
        {
            [MethodImpl(Inline)]         
            get => BaseConfig.Delimiter;
        }
    }

    public readonly struct DefaultSeqFormatConfig : ISeqFormatConfig
    {        
        public static DefaultSeqFormatConfig Default => default(DefaultSeqFormatConfig);
        
        public string Delimiter 
            => ",";
    }
}