//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class CommandProgression : ICommandProgression
    {
        readonly string Json;
        
        readonly CorrelationToken? Correlation;
        
        readonly ICommandSpec CommandSpec;

        public abstract CommandExecutionStatus Status {get;}

        protected CommandProgression(ICommandSpec spec, string json, CorrelationToken? ct = null)
        {
            CommandSpec = spec;
            Json = json;
            Correlation = ct;
        }

        protected CommandProgression(ICommandProgression src)
        {
            CommandSpec = src.Spec;
            Json = src.CommandJson;
            Correlation = src.CorrelationToken;                
        }
        
        protected CommandProgression(CommandProgression src)
        {
            CommandSpec = src.CommandSpec;
            Json = src.Json;
            Correlation = src.Correlation;
        }

        public ICommandSpec Spec 
            => CommandSpec;

        public CommandName CommandName 
            => CommandSpec.CommandName;

        public string CommandSpecName 
            => CommandSpec.SpecName;

        public string CommandJson 
            => Json;

        public CorrelationToken? CorrelationToken 
            => Correlation;       
    }

    public abstract class CommandProgression<S> : CommandProgression,  ICommandProgression<S>, ITextual
        where S : CommandSpec<S>, new()
    {
        readonly S spec;

        protected CommandProgression(ICommandProgression src)
            : base(src)
        {
            this.spec = (S)src.Spec;
        }

        protected CommandProgression(S spec, string json, CorrelationToken? ct = null)
            : base(spec, json, ct)
        {
            this.spec = spec;

        }

        protected CommandProgression(CommandProgression<S> src)
            : this(src.spec, src.CommandJson, src.CorrelationToken)
        {

        }

        public new S Spec 
            => spec;

        public string Format()
            => spec.ToString();
        
        public override string ToString()
            => Format();
    }
}