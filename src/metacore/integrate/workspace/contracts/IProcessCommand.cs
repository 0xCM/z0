//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IProcessCommand : IMessage<ProcessMessage>
    {
        /// <summary>
        /// The name of the command, unique within whatever interpretive space it is ensconced
        /// </summary>
        string CommandName {get;}

        /// <summary>
        /// The broker that submitted the command
        /// </summary>
        IProcess SubmittingProcess {get;}

        IProcessResponseMessge Ok(Type ResponseType, ProcessMessage Content);

        r Ok<r>(ProcessMessage Content)
            where r : IProcessResponseMessge;

        IProcessResponseMessge Error(Type ResponseType, ProcessMessage Content);


        r Error<r>(ProcessMessage content)
            where r : IProcessResponseMessge;
    }
}