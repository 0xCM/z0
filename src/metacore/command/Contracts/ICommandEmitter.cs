﻿//-------------------------------------------------------------------------------------------
// OSS developed by Chris Moore and licensed via MIT: https://opensource.org/licenses/MIT
// This license grants rights to merge, copy, distribute, sell or otherwise do with it 
// as you like. But please, for the love of Zeus, don't clutter it with regions.
//-------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;

public interface ICommandEmitter
{
    IEnumerable<IEmittedCommand> BuildCommands(RelativePath OutputLocation, params (string ParamName, object ParamValue)[] Parameters);

    IEnumerable<IEmittedCommand> BuildCommands(CommandName CommandName, RelativePath OutputLocation, params (string ParamName, object ParamValue)[] Parameters);

    IEnumerable<IEmittedCommand> BuildCommands(IEnumerable<CommandName> CommandNames, RelativePath OutputLocation, params (string ParamName, object ParamValue)[] Parameters);
}